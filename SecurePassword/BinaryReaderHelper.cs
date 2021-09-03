using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fazel87.IO
{
    static class BinaryReaderHelper
    {
        static bool format = true;
        public static char ReadCharBin(this BinaryReader bin, int num = 5)
        {
            try
            {
                return (char)(bin.ReadInt32() / num);
            }
            catch
            {
                format = false;
                return '0';
            }
        }
        public static string ReadStringBin(this BinaryReader bin, int num = 5)
        {
            string Result = "";
            int len = bin.ReadInt32();
            for (int i = 0; i < len; i++)
            {
                Result += ReadCharBin(bin, num);
                if (!format)
                    break;
            }
            format = true;
            return Result;
        }
    }
}
