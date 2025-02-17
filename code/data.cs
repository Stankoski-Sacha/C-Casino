using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Casino.code
{
    class data
    {
        private static int balance = 1000;
        public static int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private static int tokens = 0;
        public static int Tokens
        {
            get { return tokens; }
            set { tokens = value; }
        }
    }
}