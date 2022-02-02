
namespace CryptoTest
{
    partial class WorkSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRsaEncrypt = new System.Windows.Forms.Button();
            this.textPublic = new System.Windows.Forms.TextBox();
            this.textPrivate = new System.Windows.Forms.TextBox();
            this.lblPublic = new System.Windows.Forms.Label();
            this.lblPrivate = new System.Windows.Forms.Label();
            this.lblBase64 = new System.Windows.Forms.Label();
            this.lblDecryptString = new System.Windows.Forms.Label();
            this.textDecryptString = new Crypto_Test.ControlTextBox();
            this.textBase64 = new Crypto_Test.ControlTextBox();
            this.textEncryptString = new Crypto_Test.ControlTextBox();
            this.lblEncryptString = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRSA = new System.Windows.Forms.TabPage();
            this.btnCreateCryptoObject = new System.Windows.Forms.Button();
            this.btnRsaDecrypt = new System.Windows.Forms.Button();
            this.tpAES = new System.Windows.Forms.TabPage();
            this.textPlainTextPath = new Crypto_Test.ControlTextBox();
            this.textEncrypatedTextPath = new Crypto_Test.ControlTextBox();
            this.btnAesDecrypt = new System.Windows.Forms.Button();
            this.btnAesEncrypt = new System.Windows.Forms.Button();
            this.textDecrypted = new Crypto_Test.ControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEncrypted = new Crypto_Test.ControlTextBox();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textPassword = new Crypto_Test.ControlTextBox();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.textPlainText = new Crypto_Test.ControlTextBox();
            this.tpHASH = new System.Windows.Forms.TabPage();
            this.BtnClear = new System.Windows.Forms.Button();
            this.textHashPlainText = new System.Windows.Forms.RichTextBox();
            this.lblEncryptText = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.BtnHashEncrypt = new System.Windows.Forms.Button();
            this.rtextEncryptText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpRSA.SuspendLayout();
            this.tpAES.SuspendLayout();
            this.tpHASH.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRsaEncrypt
            // 
            this.BtnRsaEncrypt.Location = new System.Drawing.Point(537, 76);
            this.BtnRsaEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRsaEncrypt.Name = "BtnRsaEncrypt";
            this.BtnRsaEncrypt.Size = new System.Drawing.Size(123, 29);
            this.BtnRsaEncrypt.TabIndex = 0;
            this.BtnRsaEncrypt.Text = "RSA 암호화";
            this.BtnRsaEncrypt.UseVisualStyleBackColor = true;
            this.BtnRsaEncrypt.Click += new System.EventHandler(this.BtnRsaEncrypt_Click);
            // 
            // textPublic
            // 
            this.textPublic.Location = new System.Drawing.Point(26, 31);
            this.textPublic.Margin = new System.Windows.Forms.Padding(2);
            this.textPublic.Name = "textPublic";
            this.textPublic.Size = new System.Drawing.Size(471, 23);
            this.textPublic.TabIndex = 1;
            // 
            // textPrivate
            // 
            this.textPrivate.Location = new System.Drawing.Point(27, 86);
            this.textPrivate.Margin = new System.Windows.Forms.Padding(2);
            this.textPrivate.Name = "textPrivate";
            this.textPrivate.Size = new System.Drawing.Size(469, 23);
            this.textPrivate.TabIndex = 2;
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Location = new System.Drawing.Point(26, 7);
            this.lblPublic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(63, 15);
            this.lblPublic.TabIndex = 3;
            this.lblPublic.Text = "Public Key";
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.Location = new System.Drawing.Point(26, 62);
            this.lblPrivate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(94, 15);
            this.lblPrivate.TabIndex = 4;
            this.lblPrivate.Text = "Private Key Path";
            // 
            // lblBase64
            // 
            this.lblBase64.AutoSize = true;
            this.lblBase64.Location = new System.Drawing.Point(29, 220);
            this.lblBase64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase64.Name = "lblBase64";
            this.lblBase64.Size = new System.Drawing.Size(102, 15);
            this.lblBase64.TabIndex = 6;
            this.lblBase64.Text = "Encrypted Base64";
            // 
            // lblDecryptString
            // 
            this.lblDecryptString.AutoSize = true;
            this.lblDecryptString.Location = new System.Drawing.Point(27, 318);
            this.lblDecryptString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecryptString.Name = "lblDecryptString";
            this.lblDecryptString.Size = new System.Drawing.Size(85, 15);
            this.lblDecryptString.TabIndex = 7;
            this.lblDecryptString.Text = "Decrypt String";
            // 
            // textDecryptString
            // 
            this.textDecryptString.Location = new System.Drawing.Point(31, 343);
            this.textDecryptString.Margin = new System.Windows.Forms.Padding(2);
            this.textDecryptString.Multiline = true;
            this.textDecryptString.Name = "textDecryptString";
            this.textDecryptString.Size = new System.Drawing.Size(468, 61);
            this.textDecryptString.TabIndex = 8;
            // 
            // textBase64
            // 
            this.textBase64.Location = new System.Drawing.Point(29, 246);
            this.textBase64.Margin = new System.Windows.Forms.Padding(2);
            this.textBase64.Multiline = true;
            this.textBase64.Name = "textBase64";
            this.textBase64.Size = new System.Drawing.Size(468, 61);
            this.textBase64.TabIndex = 9;
            // 
            // textEncryptString
            // 
            this.textEncryptString.Location = new System.Drawing.Point(29, 147);
            this.textEncryptString.Margin = new System.Windows.Forms.Padding(2);
            this.textEncryptString.Multiline = true;
            this.textEncryptString.Name = "textEncryptString";
            this.textEncryptString.Size = new System.Drawing.Size(468, 61);
            this.textEncryptString.TabIndex = 10;
            // 
            // lblEncryptString
            // 
            this.lblEncryptString.AutoSize = true;
            this.lblEncryptString.Location = new System.Drawing.Point(29, 122);
            this.lblEncryptString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncryptString.Name = "lblEncryptString";
            this.lblEncryptString.Size = new System.Drawing.Size(83, 15);
            this.lblEncryptString.TabIndex = 11;
            this.lblEncryptString.Text = "Encrypt String";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRSA);
            this.tabControl1.Controls.Add(this.tpAES);
            this.tabControl1.Controls.Add(this.tpHASH);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 459);
            this.tabControl1.TabIndex = 12;
            // 
            // tpRSA
            // 
            this.tpRSA.Controls.Add(this.btnCreateCryptoObject);
            this.tpRSA.Controls.Add(this.btnRsaDecrypt);
            this.tpRSA.Controls.Add(this.textPublic);
            this.tpRSA.Controls.Add(this.BtnRsaEncrypt);
            this.tpRSA.Controls.Add(this.lblEncryptString);
            this.tpRSA.Controls.Add(this.textPrivate);
            this.tpRSA.Controls.Add(this.textEncryptString);
            this.tpRSA.Controls.Add(this.lblPublic);
            this.tpRSA.Controls.Add(this.textBase64);
            this.tpRSA.Controls.Add(this.lblPrivate);
            this.tpRSA.Controls.Add(this.textDecryptString);
            this.tpRSA.Controls.Add(this.lblBase64);
            this.tpRSA.Controls.Add(this.lblDecryptString);
            this.tpRSA.Location = new System.Drawing.Point(4, 24);
            this.tpRSA.Margin = new System.Windows.Forms.Padding(2);
            this.tpRSA.Name = "tpRSA";
            this.tpRSA.Padding = new System.Windows.Forms.Padding(2);
            this.tpRSA.Size = new System.Drawing.Size(695, 431);
            this.tpRSA.TabIndex = 0;
            this.tpRSA.Text = "RSA";
            this.tpRSA.UseVisualStyleBackColor = true;
            // 
            // btnCreateCryptoObject
            // 
            this.btnCreateCryptoObject.Location = new System.Drawing.Point(537, 31);
            this.btnCreateCryptoObject.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCryptoObject.Name = "btnCreateCryptoObject";
            this.btnCreateCryptoObject.Size = new System.Drawing.Size(123, 29);
            this.btnCreateCryptoObject.TabIndex = 13;
            this.btnCreateCryptoObject.Text = "RSA 암호 객체 생성";
            this.btnCreateCryptoObject.UseVisualStyleBackColor = true;
            this.btnCreateCryptoObject.Click += new System.EventHandler(this.btnCreateCryptoObject_Click);
            // 
            // btnRsaDecrypt
            // 
            this.btnRsaDecrypt.Location = new System.Drawing.Point(537, 122);
            this.btnRsaDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnRsaDecrypt.Name = "btnRsaDecrypt";
            this.btnRsaDecrypt.Size = new System.Drawing.Size(123, 29);
            this.btnRsaDecrypt.TabIndex = 12;
            this.btnRsaDecrypt.Text = "RSA 복호화";
            this.btnRsaDecrypt.UseVisualStyleBackColor = true;
            this.btnRsaDecrypt.Click += new System.EventHandler(this.btnRsaDecrypt_Click);
            // 
            // tpAES
            // 
            this.tpAES.Controls.Add(this.textPlainTextPath);
            this.tpAES.Controls.Add(this.textEncrypatedTextPath);
            this.tpAES.Controls.Add(this.btnAesDecrypt);
            this.tpAES.Controls.Add(this.btnAesEncrypt);
            this.tpAES.Controls.Add(this.textDecrypted);
            this.tpAES.Controls.Add(this.label1);
            this.tpAES.Controls.Add(this.textEncrypted);
            this.tpAES.Controls.Add(this.lblEncryptedText);
            this.tpAES.Controls.Add(this.lblPassword);
            this.tpAES.Controls.Add(this.textPassword);
            this.tpAES.Controls.Add(this.lblPlainText);
            this.tpAES.Controls.Add(this.textPlainText);
            this.tpAES.Location = new System.Drawing.Point(4, 24);
            this.tpAES.Margin = new System.Windows.Forms.Padding(2);
            this.tpAES.Name = "tpAES";
            this.tpAES.Padding = new System.Windows.Forms.Padding(2);
            this.tpAES.Size = new System.Drawing.Size(695, 431);
            this.tpAES.TabIndex = 1;
            this.tpAES.Text = "AES";
            this.tpAES.UseVisualStyleBackColor = true;
            // 
            // textPlainTextPath
            // 
            this.textPlainTextPath.Location = new System.Drawing.Point(24, 112);
            this.textPlainTextPath.Margin = new System.Windows.Forms.Padding(2);
            this.textPlainTextPath.Name = "textPlainTextPath";
            this.textPlainTextPath.Size = new System.Drawing.Size(496, 22);
            this.textPlainTextPath.TabIndex = 11;
            // 
            // textEncrypatedTextPath
            // 
            this.textEncrypatedTextPath.Location = new System.Drawing.Point(23, 237);
            this.textEncrypatedTextPath.Margin = new System.Windows.Forms.Padding(2);
            this.textEncrypatedTextPath.Name = "textEncrypatedTextPath";
            this.textEncrypatedTextPath.Size = new System.Drawing.Size(496, 22);
            this.textEncrypatedTextPath.TabIndex = 10;
            // 
            // btnAesDecrypt
            // 
            this.btnAesDecrypt.Location = new System.Drawing.Point(549, 58);
            this.btnAesDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAesDecrypt.Name = "btnAesDecrypt";
            this.btnAesDecrypt.Size = new System.Drawing.Size(114, 28);
            this.btnAesDecrypt.TabIndex = 9;
            this.btnAesDecrypt.Text = "AES 복호화";
            this.btnAesDecrypt.UseVisualStyleBackColor = true;
            this.btnAesDecrypt.Click += new System.EventHandler(this.btnAesDecrypt_Click);
            // 
            // btnAesEncrypt
            // 
            this.btnAesEncrypt.Location = new System.Drawing.Point(549, 17);
            this.btnAesEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAesEncrypt.Name = "btnAesEncrypt";
            this.btnAesEncrypt.Size = new System.Drawing.Size(114, 27);
            this.btnAesEncrypt.TabIndex = 8;
            this.btnAesEncrypt.Text = "AES 암호화";
            this.btnAesEncrypt.UseVisualStyleBackColor = true;
            this.btnAesEncrypt.Click += new System.EventHandler(this.btnAesEncrypt_Click);
            // 
            // textDecrypted
            // 
            this.textDecrypted.Location = new System.Drawing.Point(23, 309);
            this.textDecrypted.Margin = new System.Windows.Forms.Padding(2);
            this.textDecrypted.Multiline = true;
            this.textDecrypted.Name = "textDecrypted";
            this.textDecrypted.Size = new System.Drawing.Size(496, 85);
            this.textDecrypted.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Decrypted Text";
            // 
            // textEncrypted
            // 
            this.textEncrypted.Location = new System.Drawing.Point(23, 176);
            this.textEncrypted.Margin = new System.Windows.Forms.Padding(2);
            this.textEncrypted.Multiline = true;
            this.textEncrypted.Name = "textEncrypted";
            this.textEncrypted.Size = new System.Drawing.Size(496, 58);
            this.textEncrypted.TabIndex = 5;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Location = new System.Drawing.Point(23, 150);
            this.lblEncryptedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(86, 15);
            this.lblEncryptedText.TabIndex = 4;
            this.lblEncryptedText.Text = "Encrypted Text";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(216, 22);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Location = new System.Drawing.Point(277, 17);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(244, 28);
            this.textPassword.TabIndex = 2;
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(23, 22);
            this.lblPlainText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(55, 15);
            this.lblPlainText.TabIndex = 1;
            this.lblPlainText.Text = "PlainText";
            // 
            // textPlainText
            // 
            this.textPlainText.Location = new System.Drawing.Point(23, 49);
            this.textPlainText.Margin = new System.Windows.Forms.Padding(2);
            this.textPlainText.Multiline = true;
            this.textPlainText.Name = "textPlainText";
            this.textPlainText.Size = new System.Drawing.Size(497, 60);
            this.textPlainText.TabIndex = 0;
            // 
            // tpHASH
            // 
            this.tpHASH.Controls.Add(this.BtnClear);
            this.tpHASH.Controls.Add(this.textHashPlainText);
            this.tpHASH.Controls.Add(this.lblEncryptText);
            this.tpHASH.Controls.Add(this.cmbAlgorithm);
            this.tpHASH.Controls.Add(this.BtnHashEncrypt);
            this.tpHASH.Controls.Add(this.rtextEncryptText);
            this.tpHASH.Controls.Add(this.label2);
            this.tpHASH.Location = new System.Drawing.Point(4, 24);
            this.tpHASH.Name = "tpHASH";
            this.tpHASH.Size = new System.Drawing.Size(695, 431);
            this.tpHASH.TabIndex = 2;
            this.tpHASH.Text = "HASH";
            this.tpHASH.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(433, 24);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(79, 23);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "화면 지우기";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // textHashPlainText
            // 
            this.textHashPlainText.Location = new System.Drawing.Point(26, 52);
            this.textHashPlainText.Margin = new System.Windows.Forms.Padding(2);
            this.textHashPlainText.Name = "textHashPlainText";
            this.textHashPlainText.Size = new System.Drawing.Size(569, 92);
            this.textHashPlainText.TabIndex = 15;
            this.textHashPlainText.Text = "";
            // 
            // lblEncryptText
            // 
            this.lblEncryptText.AutoSize = true;
            this.lblEncryptText.Location = new System.Drawing.Point(26, 153);
            this.lblEncryptText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncryptText.Name = "lblEncryptText";
            this.lblEncryptText.Size = new System.Drawing.Size(43, 15);
            this.lblEncryptText.TabIndex = 14;
            this.lblEncryptText.Text = "암호문";
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Items.AddRange(new object[] {
            "SHA 128",
            "SHA 256",
            "SHA 384",
            "SHA 512"});
            this.cmbAlgorithm.Location = new System.Drawing.Point(299, 25);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(131, 23);
            this.cmbAlgorithm.TabIndex = 13;
            // 
            // BtnHashEncrypt
            // 
            this.BtnHashEncrypt.Location = new System.Drawing.Point(516, 24);
            this.BtnHashEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHashEncrypt.Name = "BtnHashEncrypt";
            this.BtnHashEncrypt.Size = new System.Drawing.Size(79, 23);
            this.BtnHashEncrypt.TabIndex = 12;
            this.BtnHashEncrypt.Text = "실행";
            this.BtnHashEncrypt.UseVisualStyleBackColor = true;
            this.BtnHashEncrypt.Click += new System.EventHandler(this.BtnHashEncrypt_Click);
            // 
            // rtextEncryptText
            // 
            this.rtextEncryptText.Location = new System.Drawing.Point(26, 170);
            this.rtextEncryptText.Margin = new System.Windows.Forms.Padding(2);
            this.rtextEncryptText.Name = "rtextEncryptText";
            this.rtextEncryptText.Size = new System.Drawing.Size(569, 165);
            this.rtextEncryptText.TabIndex = 11;
            this.rtextEncryptText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "원문";
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 496);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 535);
            this.Name = "WorkSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work";
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRSA.ResumeLayout(false);
            this.tpRSA.PerformLayout();
            this.tpAES.ResumeLayout(false);
            this.tpAES.PerformLayout();
            this.tpHASH.ResumeLayout(false);
            this.tpHASH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRsaEncrypt;
        private System.Windows.Forms.TextBox textPublic;
        private System.Windows.Forms.TextBox textPrivate;
        private System.Windows.Forms.Label lblPublic;
        private System.Windows.Forms.Label lblPrivate;
        private System.Windows.Forms.Label lblBase64;
        private System.Windows.Forms.Label lblDecryptString;
        private Crypto_Test.ControlTextBox textDecryptString;
        private Crypto_Test.ControlTextBox textBase64;
        private Crypto_Test.ControlTextBox textEncryptString;
        private System.Windows.Forms.Label lblEncryptString;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRSA;
        private System.Windows.Forms.TabPage tpAES;
        private System.Windows.Forms.Button btnAesDecrypt;
        private System.Windows.Forms.Button btnAesEncrypt;
        private Crypto_Test.ControlTextBox textDecrypted;
        private System.Windows.Forms.Label label1;
        private Crypto_Test.ControlTextBox textEncrypted;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.Label lblPassword;
        private Crypto_Test.ControlTextBox textPassword;
        private System.Windows.Forms.Label lblPlainText;
        private Crypto_Test.ControlTextBox textPlainText;
        private System.Windows.Forms.Button btnRsaDecrypt;
        private System.Windows.Forms.Button btnCreateCryptoObject;
        private Crypto_Test.ControlTextBox textEncrypatedTextPath;
        private Crypto_Test.ControlTextBox textPlainTextPath;
        private System.Windows.Forms.TabPage tpHASH;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RichTextBox textHashPlainText;
        private System.Windows.Forms.Label lblEncryptText;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Button BtnHashEncrypt;
        private System.Windows.Forms.RichTextBox rtextEncryptText;
        private System.Windows.Forms.Label label2;
    }
}

