using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers;

public class ElmaResponseDto
{

    public double KgPrice { get; set; }
    public Color Color { get; set; }

    public string Type { get; set; }

    public override string ToString()
    {
        return $" Kg Fiyatı : {KgPrice}, Renk : {Color}, " +
    $"Tipi : {Type}";
    }
}
