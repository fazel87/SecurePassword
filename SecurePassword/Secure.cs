using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fazel87.IO;
using fazel87.Security.AesLibrary;
using System.IO;
using System.Text.Json;

namespace SecurePassword
{
    static class Secure
    {
        static string pass = "SecurePassword2021";
        public static void SaveSecure(this SecureBase secureBase, string path)
        {
            Aes_Lib.Ecrypt_To_File(path, secureBase.ToJson(), pass);
        }
        public static SecureBase LoadSecure(string path)
        {
            return Aes_Lib.Decrypt_In_File(path, pass).ToSecureBase();
        }
        public static void SaveBSecure(this SecureBase secureBase, string path)
        {
            using (BinaryWriter bin = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                bin.WriteStringBin(Aes_Lib.Encrypt(secureBase.ToJson(),pass));
            }
        }
        public static SecureBase LoadBSecure(string path)
        {
            using(BinaryReader bin = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                return Aes_Lib.Decrypt(bin.ReadStringBin(),pass).ToSecureBase();
            }
        }
        public static SecureBase ToSecureBase(this string json)
        {
            try
            {
                return JsonSerializer.Deserialize<SecureBase>(json);
            }
            catch
            {
                return new SecureBase();
            }
        }
        public static string ToJson(this SecureBase secureBase)
        {
            try
            {
                return JsonSerializer.Serialize(secureBase);
            }
            catch
            {
                return "";
            }
        }
    }
}
