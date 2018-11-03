using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] x_plaintext = Encoding.Default.GetBytes(txtPlainText.Text);
            ElGamal x_alg = new ElGamalManaged();
            // set the key size - keep is small to speed up the tests
            x_alg.KeySize = 384;
            // extract and print the xml string (this will cause
            // a new key pair to be generated)
            string x_xml_string = x_alg.ToXmlString(true);
            ElGamal x_encrypt_alg = new ElGamalManaged();
            x_encrypt_alg.FromXmlString(x_alg.ToXmlString(false));
            byte[] x_ciphertext = x_alg.EncryptData(x_plaintext);
            lblCipherText.Text = Encoding.UTF8.GetString(x_ciphertext);

            ElGamal x_decrypt_alg = new ElGamalManaged();
            // set the keys - note that we export with the
            // private parameters since we are decrypting data
            x_decrypt_alg.FromXmlString(x_alg.ToXmlString(true));
            // restore the plaintext
            byte[] x_candidate_plaintext = x_decrypt_alg.DecryptData(x_ciphertext);
            lblPlaintext.Text = Encoding.UTF8.GetString(x_candidate_plaintext);
        }
    }
}
