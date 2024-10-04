using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers;

public class Elma
{


    public int Id { get; set; }

    public double KgPrice { get; set; }

    public Color Color { get; set; }

    public string SellerName { get; set; }

    public string Type { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, Kg Fiyatı : {KgPrice}, Renk : {Color}, " +
            $"Satııcı Adı : {SellerName}, Tipi : {Type}";
    }
}
