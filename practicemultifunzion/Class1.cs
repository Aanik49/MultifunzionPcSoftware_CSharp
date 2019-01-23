using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicemultifunzion
{
    class Class1
    {
        static string hp;
        public static string help
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }

        }
    }
}
