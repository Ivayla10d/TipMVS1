using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVS.View
{
    class Display
   {


        public double Amount { get; set; }

        public double Precent { get; set; }

        public double Total{ get; set; }

        public double Tip { get; set; }


        public void Input()
        {
            Console.WriteLine("Enter amount");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter precent");
            Precent = double.Parse(Console.ReadLine());

        }
        public void Output()
        {
            Console.WriteLine($"Your tip is {Tip:C}");
            Console.WriteLine($"The total will be {Total:C}");
        }
   }
}
