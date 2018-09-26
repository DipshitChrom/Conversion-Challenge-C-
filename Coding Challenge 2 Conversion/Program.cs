using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_2_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> NewConcept;
            IEnumerable<string> longTesting;

            List<string> test2 = new List<string>();
            List<string> testing = new List<string>();

            testing.Add("1");
            testing.Add("2");
            testing.Add("3");

            test2.Add("1");
            test2.Add("2");
            test2.Add("3");
            test2.Add("4");
            test2.Add("5");
            test2.Add("6");

            NewConcept = testing;
            longTesting = test2;
            StringsToInts(NewConcept);
            StringsToLongs(longTesting);

            string StringToConvert = "15";
            int IntToConvert = 20;
            double DoubleToConvert = 12.3;
            StringToInt(StringToConvert);
            StringToDecimal(StringToConvert);
            StringToDouble(StringToConvert);
            StringToLong(StringToConvert);

            IntToLong(IntToConvert);
            IntToShort(IntToConvert);

            DoubleToFloat(DoubleToConvert);
            DoubleToInt(DoubleToConvert);
            Console.ReadLine();
        }

        public static int StringToInt(string convertToString)
        {
            int result;
            bool a = int.TryParse(convertToString, out result);
            int convertedfromstring = Convert.ToInt32(convertToString);

            Console.WriteLine(convertedfromstring);
            return convertedfromstring;
        }

        public static decimal StringToDecimal(string convertToDecimal)
        {
            decimal convertedFromString = Convert.ToDecimal(convertToDecimal);
            Console.WriteLine(convertedFromString);
            return convertedFromString;
        }

        public static double StringToDouble(string convertToDouble)
        {
            double convertedFromString = Convert.ToDouble(convertToDouble);
            Console.WriteLine(convertedFromString);
            return convertedFromString;
        }

        public static long StringToLong(string convertToLong)
        {
            long convertedFromString = Convert.ToInt64(convertToLong);
            long convert = (long)convertToLong;
            Console.WriteLine(convertedFromString);
            return convertedFromString;
        }

        public static long IntToLong(int convertToLong)
        {
            long convertedFromInt = Convert.ToInt64(convertToLong);
            long a = (long)convertToLong;
            Console.WriteLine(convertedFromInt);
            return convertedFromInt;
        }

        public static short IntToShort(int convertToShort)
        {
            short convertedFromInt = Convert.ToInt16(convertToShort);
            short a = (short) convertToShort;
            Console.WriteLine(convertedFromInt);
            return convertedFromInt;
        }

        public static float DoubleToFloat(double convertToFloat)
        {
            float convertedFromDouble = (float) convertToFloat;
            Console.WriteLine(convertedFromDouble);
            return convertedFromDouble;
        }

        public static int DoubleToInt(double convertToInt)
        {
            int convertedFromDouble = Convert.ToInt32(convertToInt);
            Console.WriteLine(convertedFromDouble);
            return convertedFromDouble;
        }

        public static IEnumerable<int> StringsToInts(IEnumerable<string> strings)
        {
            var strArray = new[] { "a" };
            var strArray2 = new String[] { "a" };
            var strArray3 = new String[1];
            strArray3[0] = "a";

            StringsToInts(strArray3);

            string[] items = strings.ToArray<string>();
            IEnumerable<int> test;
            List<int> convertion = new List<int>();

            foreach (string stuff in items)
            {
                int myitem = Convert.ToInt32(stuff);
                convertion.Add(myitem);
            }

            var iterator = items.GetEnumerator();
            while (iterator.MoveNext() == true)
            {
                var stuff = iterator.Current;
                int myitem = Convert.ToInt32(stuff);
                convertion.Add(myitem);
            }

            test = convertion.Cast<int>();

            foreach (int number in test)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            return test;

        }

        public static IEnumerable<long> StringsToLongs(IEnumerable<string> stringstoconvert)
        {
            string[] items = stringstoconvert.ToArray<string>();
            IEnumerable<long> enumerablelong;
            List<long> convertion = new List<long>();

            foreach (string Grabitems in items)
            {
                long myItems = Convert.ToInt64(Grabitems);
                convertion.Add(myItems);
            }

            enumerablelong = stringstoconvert.Cast<long>();
            return enumerablelong;

            

            //foreach (long numbers in enumerablelong)
            //{
             //   Console.WriteLine(numbers);
            //}

        }
    }
}
