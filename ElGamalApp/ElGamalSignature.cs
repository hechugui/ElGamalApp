using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    public class ElGamalSignature
    {
        public static BigInteger mod(BigInteger p_base, BigInteger p_val)
        {
            BigInteger x_result = p_base % p_val;
            if (x_result < 0)
            {
                x_result += p_val;
            }
            return x_result;
        }
        public static byte[] CreateSignature(byte[] p_data, ElGamalKeyStruct p_key_struct)
        {
            BigInteger x_pminusone = p_key_struct.P - 1;       
            BigInteger K;
            do
            {
                K = new BigInteger();
                K.genRandomBits(p_key_struct.P.bitCount() - 1, new Random());
            } while (K.gcd(x_pminusone) != 1);

            BigInteger A = p_key_struct.G.modPow(K, p_key_struct.P);
            BigInteger B = mod(mod(K.modInverse(x_pminusone)
                * (new BigInteger(p_data)
                - (p_key_struct.X * (A))), (x_pminusone)), (x_pminusone));
            byte[] x_a_bytes = A.getBytes();
            byte[] x_b_bytes = B.getBytes();
            int x_result_size = (((p_key_struct.P.bitCount() + 7) / 8) * 2);
            byte[] x_result = new byte[x_result_size];
            Array.Copy(x_a_bytes, 0, x_result, x_result_size / 2
                - x_a_bytes.Length, x_a_bytes.Length);
            Array.Copy(x_b_bytes, 0, x_result, x_result_size
                - x_b_bytes.Length, x_b_bytes.Length);
            return x_result;
        }
        public static bool VerifySignature(byte[] p_data, byte[] p_sig, ElGamalKeyStruct p_key_struct)
        {
            int x_result_size = p_sig.Length / 2;

            byte[] x_a_bytes = new byte[x_result_size];
            Array.Copy(p_sig, 0, x_a_bytes, 0, x_a_bytes.Length);
            byte[] x_b_bytes = new Byte[x_result_size];
            Array.Copy(p_sig, x_result_size, x_b_bytes, 0, x_b_bytes.Length);

            BigInteger A = new BigInteger(x_a_bytes);
            BigInteger B = new BigInteger(x_b_bytes);
            BigInteger x_result1 = mod(p_key_struct.Y.modPow(A, p_key_struct.P)
            * A.modPow(B, p_key_struct.P), p_key_struct.P);

            BigInteger x_result2 = p_key_struct.G.modPow(new BigInteger(p_data),
                p_key_struct.P);

            return x_result1 == x_result2;
        }
    }
}
