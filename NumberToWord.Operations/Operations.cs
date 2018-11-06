using System.Collections.Generic;

namespace NumberToWord.Core
{
    public class Operations
    {
        private string fmt = "000000000000.##";
        Dictionary<char, string> ededler = new Dictionary<char, string>();
        Dictionary<char, string> onluqlar = new Dictionary<char, string>();

        public bool CheckNumberForLength(string stringNumber)
        {
            if (stringNumber.Length > 12 || stringNumber.Length < 1)
            {
                return false;
            }

            return true;
        }

        public string MakeStandartString(long number)
        {
            return number.ToString(fmt);
        }

        public void RemoveRedundantClasses(long inp, string[] array)
        {
            if (inp > 999999999)
            {
                array[4] = "milyard";
                if (inp > 99999999999)
                {
                    array[1] = "yüz";
                }
            }

            if (inp > 999999)
            {
                array[9] = "milyon";
                if (inp > 99999999)
                {
                    array[6] = "yüz";
                }
            }

            if (inp > 999)
            {
                array[14] = "min";
                if (inp > 99999)
                {
                    array[11] = "yüz";
                }
            }

            if (inp > 99)
            {
                array[16] = "yüz";
            }

            if (inp % 10000 < 2000 && inp % 10000 >= 1000 && inp < 2000)
            {
                array[13] = "";
            }
        }

        public void RemoveZeroesFromArray(string input, string[] array)
        {
            if (input[9] == '0')
            {
                array[16] = "";
            }

            if (input[6] == '0')
            {
                array[11] = "";
            }

            if (input[3] == '0')
            {
                array[6] = "";
            }

            if (input[8] == '0' && input[7] == '0' && input[6] == '0')
            {
                array[14] = "";
            }

            if (input[5] == '0' && input[4] == '0' && input[3] == '0')
            {
                array[9] = "";
            }

            if (input[2] == '0' && input[1] == '0' && input[0] == '0')
            {
                array[4] = "";
            }
        }

        public string[] CreateArrayFromString(string input)
        {
            NumberDictionaries.MakeUnits(ededler, onluqlar);
            string[] array = new string[19];

            for (int j = 18, s = 11; s >= 2; j = j - 5, s = s - 3)
            {
                array[j] = ededler[input[s]];
                array[j - 3] = ededler[input[s - 2]];
            }

            for (int j = 17, k = 10; j >= 1; j = j - 5, k = k - 3)
            {
                array[j] = onluqlar[input[k]];
            }

            for (int i = 0; i <= 15; i = i + 5)
            {
                if (array[i] == "bir")
                {
                    array[i] = "";
                }
            }

            return array;
        }
    }
}
