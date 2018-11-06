namespace ElGamalApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CipherText = new System.Windows.Forms.Label();
            this.lblCipherText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.PlainText = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CipherText
            // 
            this.CipherText.AutoSize = true;
            this.CipherText.Location = new System.Drawing.Point(84, 100);
            this.CipherText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(80, 17);
            this.CipherText.TabIndex = 0;
            this.CipherText.Text = "CipherText:";
            // 
            // lblCipherText
            // 
            this.lblCipherText.AutoSize = true;
            this.lblCipherText.Location = new System.Drawing.Point(173, 100);
            this.lblCipherText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCipherText.Name = "lblCipherText";
            this.lblCipherText.Size = new System.Drawing.Size(24, 17);
            this.lblCipherText.TabIndex = 1;
            this.lblCipherText.Text = "__";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(177, 38);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(316, 22);
            this.txtPlainText.TabIndex = 2;
            // 
            // PlainText
            // 
            this.PlainText.AutoSize = true;
            this.PlainText.Location = new System.Drawing.Point(84, 47);
            this.PlainText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(70, 17);
            this.PlainText.TabIndex = 3;
            this.PlainText.Text = "PlainText:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(88, 194);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(145, 28);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt/Decrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Location = new System.Drawing.Point(173, 148);
            this.lblPlaintext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(24, 17);
            this.lblPlaintext.TabIndex = 6;
            this.lblPlaintext.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "PlainText:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(0, 0);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 0;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(727, 38);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(145, 28);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(727, 112);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(145, 28);
            this.btnVerify.TabIndex = 9;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(88, 260);
            this.btDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(145, 28);
            this.btDecrypt.TabIndex = 10;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 521);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlaintext);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblCipherText);
            this.Controls.Add(this.CipherText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CipherText;
        private System.Windows.Forms.Label lblCipherText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label PlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btDecrypt;
    }
}

