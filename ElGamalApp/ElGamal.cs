using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalApp
{
    public abstract class ElGamal : AsymmetricAlgorithm
    {
        public abstract void ImportParameters(ElGamalParameters p_parameters);
        public abstract ElGamalParameters ExportParameters(bool
            p_include_private_params);
    }
}
