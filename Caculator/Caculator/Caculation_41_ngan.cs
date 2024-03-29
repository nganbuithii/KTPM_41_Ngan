using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public class Caculation_41_ngan
    {
        private int a, b;
        public Caculation_41_ngan(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public int Excute(string CalSymbol)
        {
            int result = 0;
            switch(CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }
    }
}
