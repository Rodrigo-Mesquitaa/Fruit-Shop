using System.ComponentModel.DataAnnotations;

namespace Fruit_Shop.Models
{
    public class Fruit
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}