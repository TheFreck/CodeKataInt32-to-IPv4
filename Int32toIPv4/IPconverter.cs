using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32toIPv4
{
    public class IPconverter
    {
        public static string GetBinary(uint input)
        {
            uint[] binaryArray = new uint[(uint)Math.Log2(input) + 1];
            uint i = 0;

            while (input > 0)
            {
                binaryArray[i] = input % 2;
                input = input / 2;
                i++;
            }
            var outString = String.Empty;
            for(var j = binaryArray.Length-1; j>=0; j--)
            {
                outString += (binaryArray.Length-j) % 8 == 0 ? binaryArray[j] + "." : binaryArray[j];
            }
            return outString.Trim('.');
        }

        public static uint FromBinary(string input)
        {
            uint base10 = 0;
            for(var i = 0; i< input.Length; i++)
            {
                var theSTring = input[input.Length-i-1].ToString();
                var theIndex = (uint)Math.Pow(2, i);
                base10 += uint.Parse(input[input.Length-i-1].ToString()) * (uint)Math.Pow(2, i);
            }
            return base10;
        }

        public static string UInt32ToIP(uint input)
        {
            if (input == 0) return "0.0.0.0";
            uint[] binaryArray = new uint[32];
            uint p = 0;

            while (input > 0)
            {
                binaryArray[p] = input % 2;
                input = input / 2;
                p++;
            }

            var IP = String.Empty;
            for(uint i=0; i<4; i++)
            {
                uint portion = 0;
                for(uint j=0; j<8; j++)
                {
                    portion += (uint)Math.Pow(2,7-j) * binaryArray[(7-j)+i*8];
                }

                IP = portion + "." + IP;
            }

            return IP.Trim('.');
        }
    }
}
