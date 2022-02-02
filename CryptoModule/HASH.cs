using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoModule
{
    public class HASH
    {
        //SHA128(SHA-1) 해쉬 함수 암호화
        public string encryptSHA128(string PlainText)
        {
            try
            {
                // 바이트로 변환
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);

                SHA1Managed sha1 = new SHA1Managed();

                byte[] EncryptBytes = sha1.ComputeHash(PlainTextBytes);

                //Base64
                string EncryptString = Convert.ToBase64String(EncryptBytes);

                return EncryptString;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //SHA256(SHA-2) 해쉬 함수 암호화
        public string encryptSHA256(string PlainText)
        {
            try
            {
                // 바이트로 변환
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);

                SHA256Managed sha2 = new SHA256Managed();

                byte[] EncryptBytes = sha2.ComputeHash(PlainTextBytes);

                //Base64
                string EncryptString = Convert.ToBase64String(EncryptBytes);

                return EncryptString;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //SHA384(SHA-3) 해쉬 함수 암호화
        public string encryptSHA384(string PlainText)
        {
            try
            {
                // 바이트로 변환
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);

                SHA384Managed sha3 = new SHA384Managed();

                byte[] EncryptBytes = sha3.ComputeHash(PlainTextBytes);

                //Base64
                string EncryptString = Convert.ToBase64String(EncryptBytes);

                return EncryptString;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //SHA512(SHA-5) 해쉬 함수 암호화
        public string encryptSHA512(string PlainText)
        {
            try
            {
                // 바이트로 변환
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);

                SHA512Managed sha5 = new SHA512Managed();

                byte[] EncryptBytes = sha5.ComputeHash(PlainTextBytes);

                //Base64
                string EncryptString = Convert.ToBase64String(EncryptBytes);

                return EncryptString;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
