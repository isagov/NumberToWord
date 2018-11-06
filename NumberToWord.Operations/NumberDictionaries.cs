using System.Collections.Generic;

namespace NumberToWord.Core
{
    public static class NumberDictionaries
    {
        public static void MakeUnits(Dictionary<char, string> units, Dictionary<char, string> tens)
        {
            units.Add('0', "");
            units.Add('1', "bir");
            units.Add('2', "iki");
            units.Add('3', "üc");
            units.Add('4', "dörd");
            units.Add('5', "beş");
            units.Add('6', "altı");
            units.Add('7', "yeddi");
            units.Add('8', "səkkiz");
            units.Add('9', "doqquz");

            tens.Add('0', "");
            tens.Add('1', "on");
            tens.Add('2', "iyirmi");
            tens.Add('3', "otuz");
            tens.Add('4', "qərx");
            tens.Add('5', "əlli");
            tens.Add('6', "altmış");
            tens.Add('7', "yetmiş");
            tens.Add('8', "seksen");
            tens.Add('9', "doxsan");
        }
    }
}
