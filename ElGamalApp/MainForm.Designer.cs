namespace ElGamalApp
{
    partial class MainForm
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
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.PlainText = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKeySizes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtDecryptedPlaintext = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CipherText
            // 
            this.CipherText.AutoSize = true;
            this.CipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.Location = new System.Drawing.Point(7, 210);
            this.CipherText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(91, 17);
            this.CipherText.TabIndex = 0;
            this.CipherText.Text = "CipherText:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(120, 32);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(411, 71);
            this.txtPlainText.TabIndex = 2;
            // 
            // PlainText
            // 
            this.PlainText.AutoSize = true;
            this.PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainText.Location = new System.Drawing.Point(7, 32);
            this.PlainText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(80, 17);
            this.PlainText.TabIndex = 3;
            this.PlainText.Text = "PlainText:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(310, 163);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(221, 28);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
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
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(727, 38);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(145, 28);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(727, 112);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(145, 28);
            this.btnVerify.TabIndex = 9;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrypt.Location = new System.Drawing.Point(310, 146);
            this.btDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(221, 28);
            this.btDecrypt.TabIndex = 10;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCiphertext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboKeySizes);
            this.groupBox1.Controls.Add(this.txtPlainText);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.PlainText);
            this.groupBox1.Controls.Add(this.CipherText);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 302);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enkriptimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Madhesia e çelësit:";
            // 
            // cboKeySizes
            // 
            this.cboKeySizes.FormattingEnabled = true;
            this.cboKeySizes.Location = new System.Drawing.Point(310, 119);
            this.cboKeySizes.Name = "cboKeySizes";
            this.cboKeySizes.Size = new System.Drawing.Size(221, 24);
            this.cboKeySizes.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDecryptedPlaintext);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btDecrypt);
            this.groupBox2.Location = new System.Drawing.Point(25, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 193);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dekriptimi";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(126, 210);
            this.txtCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(411, 71);
            this.txtCiphertext.TabIndex = 7;
            // 
            // txtDecryptedPlaintext
            // 
            this.txtDecryptedPlaintext.Location = new System.Drawing.Point(123, 35);
            this.txtDecryptedPlaintext.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecryptedPlaintext.Multiline = true;
            this.txtDecryptedPlaintext.Name = "txtDecryptedPlaintext";
            this.txtDecryptedPlaintext.Size = new System.Drawing.Size(411, 71);
            this.txtDecryptedPlaintext.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSign);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CipherText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label PlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKeySizes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtDecryptedPlaintext;
    }
}

