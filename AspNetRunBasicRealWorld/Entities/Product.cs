using System.ComponentModel.DataAnnotations;

namespace AspNetRunBasicRealWorld.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(40)]
        public string Slug { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public int UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
