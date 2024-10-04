using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models;

public class Categgory
{

    public int Id { get; set; }

    public string Name { get; set; }

    public List<Book> Books{ get; set; }


    public static Categgory operator + (Categgory c,Book b)
    {
        c.Books.Add(b);
     return c;
    }

    //  - operatörünü ezerek ilgili kategoriden kitap nesnesini listeden çıkaran kofu yazınız.


    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}
