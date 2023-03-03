using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PupassureTest
{
    public class RegWindow
    {
        public bool PetsNameLenght(string name)
        {
            if (name.Length < 15 && name.Length > 0)
                return true;
            else
                return false;
        }

        public bool PetsBreedLenght(string breed)
        {
            if (breed.Length > 0 && breed.Length < 10)
                return true;
            else
                return false;
        }

        public bool BirtdayLenght(string date)
        {
            if (date.Length == 10)
                return true;
            else
                return false;
        }

        public bool PetsNameCapital(string name)
        {
            string pattern = @"[А-Я](\w+)";
            if (Regex.IsMatch(name,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
