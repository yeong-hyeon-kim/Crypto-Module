using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoModule
{
    public class RSA
    {
        string EncodingString = "";

        public void DebugCreateCryptoObject(string Password)
        {
            // 암호화 객체 생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            // 개인키 생성(복호화)
            RSAParameters PrivateKey = System.Security.Cryptography.RSA.Create().ExportParameters(true);
            rsa.ImportParameters(PrivateKey);

            string PrivateKeyText = rsa.ToXmlString(true);
            // 개인키 파일 저장
            ExportKey("PrivateKey.xml", PrivateKeyText);

            // 공개키 생성(암호화)
            RSAParameters PublicKey = new RSAParameters();
            PublicKey.Modulus = PrivateKey.Modulus;
            PublicKey.Exponent = PrivateKey.Exponent;
            rsa.ImportParameters(PublicKey);

            string PublicKeyText = rsa.ToXmlString(false);
            // 공개키 파일 저장
            ExportKey("PublicKey.xml", PublicKeyText);

            EncodingString = RSAEncrypt(Password, PublicKeyText);
            string DecodedString = RSADecrypt(EncodingString, PrivateKeyText);

            Debug.WriteLine(Password);
            Debug.WriteLine(EncodingString);
            Debug.WriteLine(DecodedString);
        }

        public void CreateCryptoObject()
        {
            // 암호화 객체 생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            // 개인키 생성(복호화)
            RSAParameters PrivateKey = System.Security.Cryptography.RSA.Create().ExportParameters(true);
            rsa.ImportParameters(PrivateKey);

            string PrivateKeyText = rsa.ToXmlString(true);
            // 개인키 파일 저장
            ExportKey("PrivateKey.xml", PrivateKeyText);

            // 공개키 생성(암호화)
            RSAParameters PublicKey = new RSAParameters();
            PublicKey.Modulus = PrivateKey.Modulus;
            PublicKey.Exponent = PrivateKey.Exponent;
            rsa.ImportParameters(PublicKey);

            string PublicKeyText = rsa.ToXmlString(false);
            // 공개키 파일 저장
            ExportKey("PublicKey.xml", PublicKeyText);
        }

        public string RSAEncrypt(string Value, string PublicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(PublicKey);

            // 암호화할 문자열을 UTF-8 인코딩
            byte[] InBuf = (new UTF8Encoding()).GetBytes(Value);
            // 암호화
            byte[] EncBuf = rsa.Encrypt(InBuf, false);

            // 암호화된 문자열 Base64 인코딩
            return Convert.ToBase64String(EncBuf);
        }

        public string RSADecrypt(string Value, string PrivateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(PrivateKey);

            // 문자열을 바이트 배열로 변환
            byte[] SrcBuf = Convert.FromBase64String(Value);
            // 바이트 배열 복호화
            byte[] DecBuf = rsa.Decrypt(SrcBuf, false);

            // 복호화 바이트 배열을 문자열로 변환
            string Dec = (new UTF8Encoding()).GetString(DecBuf, 0, DecBuf.Length);
            return Dec;
        }

        private void ExportKey(string Title, string XmlString)
        {
            File.WriteAllText($"{Path.Combine(Environment.CurrentDirectory)}{@"\"}{Title}", XmlString);
        }
    }
}
