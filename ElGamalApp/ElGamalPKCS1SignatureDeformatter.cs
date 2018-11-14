﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    class ElGamalPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
        private string o_hash_name;   
        private ElGamalManaged o_key;   

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
                throw new ArgumentException("Qelesi nuk eshte instance e ElGamal Managed", "p_key");
            }
        }

        public override bool VerifySignature(byte[] p_data, byte[] p_signature)
        {
            if (o_hash_name == null || o_key == null)
            {
                throw new
                    CryptographicException("Qelesi dhe Hash Algoritmi duhet te caktohen!");
            }
            else
            {
                HashAlgorithm x_hash_alg = HashAlgorithm.Create(o_hash_name);

                byte[] x_pkcs = ElGamalSignatureFormatHelper.CreateEMSA_PKCS1_v1_5_ENCODE( p_data, x_hash_alg, o_key.KeyStruct.P.bitCount());

                return o_key.VerifySignature(x_pkcs, p_signature);
            }
        }
    }

}
