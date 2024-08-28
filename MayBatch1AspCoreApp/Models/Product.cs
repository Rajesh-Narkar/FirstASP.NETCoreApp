using System.ComponentModel.DataAnnotations;
namespace MayBatch1AspCoreApp.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pcat { get; set; }
        public string Pimage { get; set; }
        public double Price { get; set; }
    }
}
