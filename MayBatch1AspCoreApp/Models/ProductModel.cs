using System.ComponentModel.DataAnnotations;
namespace MayBatch1AspCoreApp.Models
{
    public class ProductModel
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }

        public string Pcat { get; set; }
        public IFormFile Pimage { get; set; }
        public double Price { get; set; }
    }
}

