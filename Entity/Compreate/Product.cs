using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Compreate
{
    public class Product
    {
        [Key]
        public int? ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public virtual Category Category { get; set; }
    //Product sınıfının her bir örneği için bir Category (kategori) nesnesine sahip olduğunu gösterir.
    
    
    }
}
