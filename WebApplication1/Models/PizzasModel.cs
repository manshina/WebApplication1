using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PizzasModel
    {
        [Key]
        public int Id { get; set; }
        public string ImgSource { get; set; }
        [Required]
        public string Name { get; set; }
        public int BasePrice { get; set; } = 2; 

        public bool Tomato { get; set; }
        public bool Cheese { get; set; }
        public bool Pepper { get; set; }
        public bool Mushroom { get; set; }
        public bool Salat { get; set; }
        public int FinalPrice { get; set; }
    }
}
