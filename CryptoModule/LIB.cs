using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoModule
{
    public class LIB : AES
    {
        public void EncryptLog(string PlainText, string Password, string LogTitle = "Log")
        {
            string EncryptedData = AESEncrypt256(PlainText, Password) + Convert.ToChar(10);
            ExportLog(LogTitle, EncryptedData);
        }

        public string DecryptLog(string EncryptedText, string Password)
        {
            string[] SplitText = EncryptedText.Split(Convert.ToChar(10));
            string DecryptedString = "";

            foreach (string item in SplitText)
            {
                DecryptedString += AESDecrypt256(item, Password);
            }

            return DecryptedString;
        }

        private void ExportLog(string Title, string Content, bool ExportYn = true)
        {
            if (ExportYn)
            {
                string Path = System.IO.Path.Combine(Environment.CurrentDirectory, $"{DateTime.Now:yyyy-MM-dd}_{Title}.txt");
                File.AppendAllText(Path, Content);
            }
        }
    }
}
