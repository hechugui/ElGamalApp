using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    public class ElGamalPKCS1SignatureFormatter : AsymmetricSignatureFormatter 
    {
        private string o_hash_name;    // the hash algorithm to use
        private ElGamalManaged o_key;          // the ElGamal algorithm

        public override void SetHashAlgorithm(string p_name)
        {
            o_hash_name = p_name;
        }

        public override void SetKey(AsymmetricAlgorithm p_key)
        {
            if (p_key is ElGamalManaged)
            {
                o_key = p_key as ElGamalManaged;
            }
            else
            {
                throw new ArgumentException(
                    "Key is not an instance of ElGamalManaged", "p_key");
            }
        }

        public override byte[] CreateSignature(byte[] p_data)
        {
            if (o_hash_name == null || o_key == null)
            {
                throw new
                    CryptographicException("Key and Hash Algorithm must be set");
            }
            else
            {
                // create the hashing algorithm
                HashAlgorithm x_hash_alg = HashAlgorithm.Create(o_hash_name);
                // create a PKCS1 formatted block from the data
                byte[] x_pkcs
                   = ElGamalSignatureFormatHelper.CreateEMSA_PKCS1_v1_5_ENCODE(p_data,
                   x_hash_alg, o_key.KeyStruct.P.bitCount());
                // create and return the signature
                return o_key.Sign(x_pkcs);
            }
        }
    }
}
