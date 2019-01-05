using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExemplo
{
    public class ConversorFooBaa
    {
        public string ConverterMutiplo(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "foobaa";

            if(num % 3 == 0) return "foo";

            if (num % 5 == 0) return "baa";

            return "";
        }
    }
}
