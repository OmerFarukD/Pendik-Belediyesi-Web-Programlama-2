using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Repository
{
    public class MsSqlOrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            Console.WriteLine("Sipariş eklendi (MsSQL)");
            Console.WriteLine(order);
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Sipariş silindi (MsSQL)");
            Console.WriteLine(order);
        }

        public void GetAll()
        {
            Console.WriteLine("Siparişler Listelendi (MsSQL)");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Sipariş GÜNCELLENDİ (MsSQL)");
            Console.WriteLine(order);
        }
    }
}
