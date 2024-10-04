using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers
{
    public class CreateElmaDto
    {
       
        public double KgPrice { get; set; }
      
        public Color Color { get; set; }
       
        public string SellerName { get; set; }

        public string Type { get; set; }
    }
}
