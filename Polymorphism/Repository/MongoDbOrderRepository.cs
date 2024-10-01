using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Repository
{
    public class MongoDbOrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            Console.WriteLine("Mongo Db ye eklendi : ");
            Console.WriteLine(order);
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Mongo Db den silindi : ");
            Console.WriteLine(order);
        }

        public void GetAll()
        {
            Console.WriteLine("Mongo Db de listelendi : ");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Mongo Db de güncellendi : ");
            Console.WriteLine(order);
        }
    }
}
