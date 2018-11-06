using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        ElGamal x_alg = new ElGamalManaged();
        ElGamal x_encrypt_alg = new ElGamalManaged();
        ElGamal x_decrypt_alg = new ElGamalManaged();
        byte[] x_ciphertext = null;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] x_plaintext
            = Encoding.Default.GetBytes(txtPlainText.Text);

            // Create an instance of the algorithm and generate some keys
         
            // set the key size - keep is small to speed up the tests
            x_alg.KeySize = 384;
            // extract and print the xml string (this will cause
            // a new key pair to be generated)
            string x_xml_string = x_alg.ToXmlString(true);
            // Test the basic encryption support
            
            // set the keys - note that we export without the
            // private parameters since we are encrypting data
            x_encrypt_alg.FromXmlString(x_alg.ToXmlString(false));

           
            x_ciphertext = x_alg.EncryptData(x_plaintext);
            //byte[] x_ciphertext = x_alg.EncryptData(x_plaintext);
            txtCiphertext.Text = Encoding.UTF8.GetString(x_ciphertext);


            // set the keys - note that we export with the
            // private parameters since we are decrypting data


        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            byte[] x_plaintext = Encoding.UTF8.GetBytes(txtPlainText.Text);
            // Create an instance of the algorithm and generate some keys
            ElGamal x_alg = new ElGamalManaged();
            // set the key size - keep is small to speed up the tests
            x_alg.KeySize = 384;
            // extract and print the xml string (this will cause
            // a new key pair to be generated)
            string x_xml_string = x_alg.ToXmlString(true);

            ElGamal x_sign_alg = new ElGamalManaged();
            // set the keys - note that we export with the
            // private parameters since we are signing data
            x_sign_alg.FromXmlString(x_alg.ToXmlString(true));
            byte[] x_signature = x_sign_alg.Sign(x_plaintext);
            // verify the signature
            ElGamal x_verify_alg = new ElGamalManaged();
            // set the keys - note that we export without the
            // set the keys - note that we export without the
            // private parameters since we are verifying data
            x_verify_alg.FromXmlString(x_alg.ToXmlString(false));

            x_verify_alg.VerifySignature(x_plaintext, x_signature);

            HashAlgorithm x_hash_alg = HashAlgorithm.Create("SHA1");
            byte[] x_hashcode = x_hash_alg.ComputeHash(x_plaintext);

            ElGamalPKCS1SignatureFormatter x_sig_formatter
            = new ElGamalPKCS1SignatureFormatter();
            x_sig_formatter.SetHashAlgorithm("SHA1");
            x_sig_formatter.SetKey(x_sign_alg);
            x_signature = x_sig_formatter.CreateSignature(x_hashcode);

            ElGamalPKCS1SignatureDeformatter x_sig_deformatter
            = new ElGamalPKCS1SignatureDeformatter();
            x_sig_deformatter.SetHashAlgorithm("SHA1");
            x_sig_deformatter.SetKey(x_verify_alg);

            MessageBox.Show(x_sig_deformatter.VerifySignature(x_hashcode, x_signature).ToString());


        }
        private static bool CompareArrays(byte[] p_arr1, byte[] p_arr2)
        {
            for (int i = 0; i < p_arr1.Length; i++)
            {
                if (p_arr1[i] != p_arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            x_decrypt_alg.FromXmlString(x_alg.ToXmlString(true));
            byte[] x_candidate_plaintext = x_decrypt_alg.DecryptData(x_ciphertext);

            txtDecryptedPlaintext.Text = Encoding.UTF8.GetString(x_candidate_plaintext);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboKeySizes.DataSource = x_alg.LegalKeySizes;
            cboKeySizes.DisplayMember = "";
        }
    }
}
