using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Compreate
{
   public class Category
    {
        [Key]
        public int? CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set;}
        //kategoriler içinde ürünün çoğul olarak gelceğini gösteren yapı
        //Category ile Product sınıfı arasındaki ilişkiyi temsil eder. Bu satır, Category sınıfının içinde bir veya daha fazla Product nesnesi barındırabileceğini belirtir.


    }
}
