using System.ComponentModel.DataAnnotations;

namespace Web_API.Model
{
    public class Car
    {
        [Key]
        public int Car_Id { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        public string Price { get; set; }
    }
}
