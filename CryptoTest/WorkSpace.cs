using CryptoModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace CryptoTest
{
    public partial class WorkSpace : Form
    {
        public WorkSpace()
        {
            InitializeComponent();
        }

        private void btnCreateCryptoObject_Click(object sender, EventArgs e)
        {
            RSA cry = new RSA();
            cry.CreateCryptoObject();
        }

        private void BtnRsaEncrypt_Click(object sender, EventArgs e)
        {
            RSA cry = new RSA();
            textBase64.Text = cry.RSAEncrypt(textEncryptString.Text, File.ReadAllText(textPublic.Text));
        }

        private void btnRsaDecrypt_Click(object sender, EventArgs e)
        {
            RSA cry = new RSA();
            textDecryptString.Text = cry.RSADecrypt(textBase64.Text, File.ReadAllText(textPrivate.Text));
        }

        private void btnAesEncrypt_Click(object sender, EventArgs e)
        {
            LIB cry = new LIB();

            if (!string.IsNullOrEmpty(textPlainText.Text))
            {
                cry.EncryptLog(textPlainText.Text, textPassword.Text);
            }
            else
            {
                cry.EncryptLog(File.ReadAllText(textPlainTextPath.Text), textPassword.Text);
            }
        }

        private void btnAesDecrypt_Click(object sender, EventArgs e)
        {
            AES cry = new AES();
            //textDecrypted.Text = cry.AESDecrypt256(textEncrypted.Text, textPassword.Text);
            if (!string.IsNullOrEmpty(textEncrypatedTextPath.Text))
            {
                textDecrypted.Text = LogDecrypto(File.ReadAllText(textEncrypatedTextPath.Text));
            }
            else
            {
                textDecrypted.Text = LogDecrypto(textEncrypted.Text);
            }
        }

        public string LogDecrypto(string EncrypatedText)
        {
            AES cry = new AES();

            string[] SplitText = EncrypatedText.Split(Convert.ToChar(10));
            string DecryptedString = "";

            foreach (string item in SplitText)
            {
                DecryptedString += cry.AESDecrypt256(item, textPassword.Text);
            }

            return DecryptedString;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            rtextEncryptText.Text = string.Empty;
            textHashPlainText.Text = string.Empty;
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {
            cmbAlgorithm.SelectedIndex = 0;
        }

        private void BtnHashEncrypt_Click(object sender, EventArgs e)
        {
            HASH cry = new HASH();

            switch (cmbAlgorithm.SelectedIndex)
            {
                case 0:
                    rtextEncryptText.Text = cry.encryptSHA128(textHashPlainText.Text);
                    break;
                case 1:
                    rtextEncryptText.Text = cry.encryptSHA256(textHashPlainText.Text);
                    break;
                case 2:
                    rtextEncryptText.Text = cry.encryptSHA384(textHashPlainText.Text);
                    break;
                case 3:
                    rtextEncryptText.Text = cry.encryptSHA512(textHashPlainText.Text);
                    break;
            }
        }
    }
}
