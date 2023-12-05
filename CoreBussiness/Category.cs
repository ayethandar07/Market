using System.ComponentModel.DataAnnotations;

namespace CoreBussiness
{
    public class Category
    {
        public int CategoryId  { get ; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        //navigation property for ef core
        public List<Product> Products { get; set; }
    }
}