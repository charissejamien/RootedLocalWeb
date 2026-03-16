using Postgrest.Attributes;
using Postgrest.Models;

namespace RootedLocalWeb.Models;

[Table("Produce")]
    public class ProduceItem : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = " ";
        [Column("price")]
        public decimal Price { get; set; }
        [Column("unit")]
        public string Unit { get; set; } = " ";
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; } = " ";
    }
