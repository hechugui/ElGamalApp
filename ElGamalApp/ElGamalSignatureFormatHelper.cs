using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    public class ElGamalSignatureFormatHelper
    {
        private static byte[] MD5_BYTES
        = new byte[] {0x30, 0x20, 0x30, 0x0C, 0x06, 0x08, 0x2A, 0x86,
                         0x48, 0x86, 0xF7, 0x0D, 0x02, 0x05, 0x05, 0x00,
                         0x04, 0x10};

        private static byte[] SHA1_BYTES
            = new byte[] {0x30, 0x21, 0x30, 0x09, 0x06, 0x05, 0x2b, 0x0E, 0x03,
                         0x02, 0x1A, 0x05, 0x00, 0x04, 0x14};

        private static byte[] SHA256_BYTES
            = new byte[] {0x30, 0x31, 0x30, 0x0d, 0x06, 0x09, 0x60, 0x86,
                         0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x01, 0x05,
                         0x00, 0x04, 0x20};

        private static byte[] SHA384_BYTES
            = new byte[] {0x30, 0x41, 0x30, 0x0d, 0x06, 0x09, 0x60, 0x86,
                         0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x02, 0x05,
                         0x00, 0x04, 0x30};

        private static byte[] SHA512_BYTES
            = new byte[] {0x30, 0x51, 0x30, 0x0d, 0x06, 0x09, 0x60, 0x86,
                         0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x03, 0x05,
                         0x00, 0x04, 0x40};

        private static byte[] GetHashAlgorithmID(HashAlgorithm p_hash)
        {
            if (p_hash is MD5)
            {
                return MD5_BYTES;
            }
            else if (p_hash is SHA1)
            {
                return SHA1_BYTES;
            }
            else if (p_hash is SHA256)
            {
                return SHA256_BYTES;
            }
            else if (p_hash is SHA384)
            {
                return SHA384_BYTES;
            }
            else if (p_hash is SHA512)
            {
                return SHA512_BYTES;
            }
            else
            {
                throw new ArgumentException("Hash algoritem i panjohur!", "p_hash");
            }
        }

        public static byte[] CreateEMSA_PKCS1_v1_5_ENCODE(byte[] p_hashcode, HashAlgorithm p_hash_alg, int p_key_length)
        {

            byte[] x_algorithm_id = GetHashAlgorithmID(p_hash_alg);
            byte[] T = new byte[p_hashcode.Length + x_algorithm_id.Length];

            Array.Copy(x_algorithm_id, 0, T, 0, x_algorithm_id.Length);
            Array.Copy(p_hashcode, 0, T, x_algorithm_id.Length, p_hashcode.Length);

            int x_PS_length = p_key_length - T.Length - 3;
            byte[] PS = new byte[x_PS_length < 0 ? 8 : x_PS_length];

            for (int i = 0; i < PS.Length; i++)
            {
                PS[i] = 0xFF;
            }
        
            byte[] EM = new byte[3 + PS.Length + T.Length];
            EM[0] = 0x00;
            EM[1] = 0x01;

            Array.Copy(PS, 0, EM, 2, PS.Length);
            EM[PS.Length + 2] = 0x00;
            Array.Copy(T, 0, EM, PS.Length + 3, T.Length);
        
            return EM;

        }
    }
}


