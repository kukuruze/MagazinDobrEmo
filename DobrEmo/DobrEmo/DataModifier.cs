using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobrEmo
{
    static class DataModifier
    {
        public static string CyrillicToLatin(string text)
        {
            text = text
       .Replace("\u0401", "YO")
       .Replace("\u0419", "I")
       .Replace("\u0426", "TS")
       .Replace("\u0423", "U")
       .Replace("\u041A", "K")
       .Replace("\u0415", "E")
       .Replace("\u041D", "N")
       .Replace("\u0413", "G")
       .Replace("\u0428", "SH")
       .Replace("\u0429", "SCH")
       .Replace("\u0417", "Z")
       .Replace("\u0425", "H")
       .Replace("\u042A", "g")
       .Replace("\u0451", "yo")
       .Replace("\u0439", "i")
       .Replace("\u0446", "ts")
       .Replace("\u0443", "u")
       .Replace("\u043A", "k")
       .Replace("\u0435", "e")
       .Replace("\u043D", "n")
       .Replace("\u0433", "")
       .Replace("\u0448", "sh")
       .Replace("\u0449", "sch")
       .Replace("\u0437", "z")
       .Replace("\u0445", "h")
       .Replace("\u044A", "u")
       .Replace("\u0424", "F")
       .Replace("\u042B", "I")
       .Replace("\u0412", "V")
       .Replace("\u0410", "a")
       .Replace("\u041F", "P")
       .Replace("\u0420", "R")
       .Replace("\u041E", "O")
       .Replace("\u041B", "L")
       .Replace("\u0414", "D")
       .Replace("\u0416", "ZH")
       .Replace("\u042D", "E")
       .Replace("\u0444", "f")
       .Replace("\u044B", "i")
       .Replace("\u0432", "v")
       .Replace("\u0430", "a")
       .Replace("\u043F", "p")
       .Replace("\u0440", "r")
       .Replace("\u043E", "o")
       .Replace("\u043B", "l")
       .Replace("\u0434", "d")
       .Replace("\u0436", "zh")
       .Replace("\u044D", "e")
       .Replace("\u042F", "Ya")
       .Replace("\u0427", "CH")
       .Replace("\u0421", "S")
       .Replace("\u041C", "M")
       .Replace("\u0418", "I")
       .Replace("\u0422", "T")
       .Replace("\u042C", "i")
       .Replace("\u0411", "B")
       .Replace("\u042E", "YU")
       .Replace("\u044F", "ya")
       .Replace("\u0447", "ch")
       .Replace("\u0441", "s")
       .Replace("\u043C", "m")
       .Replace("\u0438", "i")
       .Replace("\u0442", "t")
       .Replace("\u044C", "i")
       .Replace("\u0431", "b")
       .Replace("\u044E", "yu");

            return text;
        }
    }
}
