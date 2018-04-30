using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args) {
            int hexal = 323;
            int dec = 123;
            int Base = 5;

            Console.WriteLine("Die Sechserzahl " + hexal + " wird zur Dezimalzahl " + ConvertHexalToDezima(hexal));
            Console.WriteLine("Die Dezimalzahl " + dec + " wird zur Sechserzahl " + ConvertDecimalToHexal(dec));
            Console.WriteLine("Die Dezimalzahl " + dec + " wird mit Basis " + Base + " zu " + ConvertFromBaseToDecimal(Base, dec));
            Console.WriteLine(ConvertToDecimalFromBase(Base, dec);
        }

        static int ConvertHexalToDezima(int hexal) {
            int result = 0;
            int h = hexal.ToString().Length;
            for (int i = 0; i < h; i++)
            {
                double potenz = Math.Pow(6, Convert.ToDouble(i));
                int rest = (hexal % 10) * Convert.ToInt32(potenz);
                result = rest + result;
                hexal = hexal / 10;
            }
            return result;
        }

        static int ConvertDecimalToHexal(int dec) {  
            int[] rest = new int[dec.ToString().Length];
            string read = "";
            for (int i = 0; i < dec.ToString().Length ; i++)
            {
                rest[i] = (dec%6);
                read = rest[i] + read;
                dec = (dec/6);
            }
            return Convert.ToInt32(read);
        } 
    

        public static int ConvertToBaseFromDecimal(int toBase, int dec)
        {
            int value;
            int modulo;
            int[] arr = new int[4];
            if (0 <= dec && dec <= 1023)
            {
                for (int i = 0; i <= dec.ToString().Length + 2; i++)
                {
                    value = dec / toBase;
                    modulo = dec % toBase;
                    arr[i] = modulo;
                    dec = value;
                }
            }
            Array.Reverse(arr);
            int sum = Convert.ToInt32((string.Join("", arr)));
            return sum;
        }

        public static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int length = number.ToString().Length;
            int[] array = new int[length];
            int[] arr = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = number % 10;
                number /= 10;
                arr[i] += array[i] * Convert.ToInt32(Math.Pow(fromBase, i));
            }
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            return sum;
        }
        public static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase)
        {

            if (2 <= fromBase && fromBase <= 10 && 2 <= toBase && toBase <= 10)
            {
                int dec = ConvertToDecimalFromBase(fromBase, number);
                int value = ConvertToBaseFromDecimal(toBase, dec);
                return value;
            }
            return -1;
        }
    }
}
