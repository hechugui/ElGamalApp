using ElGamalApp.Properties;
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
            byte[] x_plaintext = Encoding.UTF8.GetBytes(txtPlainText.Text);
   
            x_alg.KeySize = int.Parse(cboKeySizes.SelectedValue.ToString());

            string x_xml_string = x_alg.ToXmlString(true);
   
            x_encrypt_alg.FromXmlString(x_alg.ToXmlString(false));

            x_ciphertext = x_alg.EncryptData(x_plaintext);

            txtCiphertext.Text = Convert.ToBase64String(x_ciphertext);
        }

        byte[] x_plaintextForSignature = null,x_signature = null;
        ElGamal x_alg_signature = new ElGamalManaged();
        private void btnSign_Click(object sender, EventArgs e)
        {
            x_plaintextForSignature = Encoding.UTF8.GetBytes(txtSignPlaintext.Text);

            x_alg_signature.KeySize = int.Parse(cboKeySizes.SelectedValue.ToString());

            string x_xml_string = x_alg_signature.ToXmlString(true);

            ElGamal x_sign_alg = new ElGamalManaged();

            x_sign_alg.FromXmlString(x_alg_signature.ToXmlString(true));
            x_signature = x_sign_alg.Sign(x_plaintextForSignature);
            txtSignedPlainText.Text = Convert.ToBase64String(x_signature);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            x_plaintextForSignature = Encoding.UTF8.GetBytes(txtSignPlaintext.Text);

            ElGamal x_verify_alg = new ElGamalManaged();

            x_verify_alg.FromXmlString(x_alg_signature.ToXmlString(false));

            bool IsValid = x_verify_alg.VerifySignature(x_plaintextForSignature, x_signature);
            if (IsValid)
            {
                pbIsValid.Visible = true;
                pbIsValid.Image = Resources.Valid;
            }
            else
            {
                pbIsValid.Visible = true;
                pbIsValid.Image = Resources.InValid;
            }

        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            x_decrypt_alg.FromXmlString(x_alg.ToXmlString(true));

            byte[] x_candidate_plaintext = x_decrypt_alg.DecryptData(x_ciphertext);

            txtDecryptedPlaintext.Text = Encoding.UTF8.GetString(x_candidate_plaintext);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboKeySizes.DataSource = getKeySizes();
            pbIsValid.Visible = false;
        }


        public List<String> getKeySizes()
        {
            List<String> keySizesForCbo = new List<string>();
            KeySizes[] ks = x_alg.LegalKeySizes;
            int key = ks[0].MinSize;
            while (key <= ks[0].MaxSize)
            {
                keySizesForCbo.Add(key.ToString());
                key += ks[0].SkipSize;
            }
            return keySizesForCbo;
        }
    }
}
