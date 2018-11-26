using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EDS_RSA_SHA384
{
    class EDSService {
        private static RSACryptoServiceProvider RSA;
        private static byte[] Sign, Hash;

        static EDSService()
        {
            RSA = new RSACryptoServiceProvider();
        }

        public static byte[] CreateSignature(string source)
        {
            var bytes = Encoding.Unicode.GetBytes(source);
            Hash = new SHA384Managed().ComputeHash(bytes);
            var rsaParams = RSA.ExportParameters(false);
            Sign = RSA.SignHash(Hash, HashAlgorithmName.SHA384, RSASignaturePadding.Pkcs1);
            return Sign;
        }
        
        public static bool CheckSignature(byte[] sign)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(RSA.ExportParameters(false));
            var signStrView = BitConverter.ToString(sign);
            return rsa.VerifyHash(Hash, sign, HashAlgorithmName.SHA384, RSASignaturePadding.Pkcs1);
        }

        public static string GetInfo()
        {
            var info = "";
            var rsaParams = RSA.ExportParameters(true);
            info += "Hash: " + BitConverter.ToString(Hash) + "\r\n" +
                "Hash size: " + Hash.Length + "\r\n" +
                "Sign " + BitConverter.ToString(Sign) + "\r\n" +
                "Sign size: " + Sign.Length + "\r\n" +
                "RSA key size: " + RSA.KeySize +
                "\r\n\r\nn: " + BitConverter.ToString(rsaParams.Modulus) +
                "\r\n\r\ne: " + BitConverter.ToString(rsaParams.Exponent) +
                "\r\n\r\nP: " + BitConverter.ToString(rsaParams.P) +
                "\r\n\r\nQ: " + BitConverter.ToString(rsaParams.Q) +
                "\r\n\r\nd: " + BitConverter.ToString(rsaParams.D);
            return info;
        }
    }
}
