using System.ComponentModel.DataAnnotations;
namespace MayBatch1AspCoreApp.Models
{
    public class Emp
    {
        [Required(ErrorMessage="Id is required")]
        [Range(1,100,ErrorMessage ="Id must be between 1-100")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Id is required")]
        [StringLength(20,MinimumLength =10,ErrorMessage ="lenght should be between 10 and 20")]
        [RegularExpression(@"^S.*", ErrorMessage = "Name should start with S")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Id is required")]       
        public double Salary {  get; set; }
    }
}
