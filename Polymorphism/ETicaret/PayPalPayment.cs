using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.ETicaret
{
    public class PayPalPayment : BasePayment
    {

        public string Email { get; set; }
        public override void Pay()
        {
            Console.WriteLine($"Email :{Email}, Tutar : {Amount}");
        }
    }
}
