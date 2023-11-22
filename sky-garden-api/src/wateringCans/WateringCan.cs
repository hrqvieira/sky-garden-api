using System.ComponentModel.DataAnnotations;

namespace sky_garden_api.src.wateringCans
{
    public class WateringCan
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model{ get; set; }

        public string Status{ get; set; }

        public string PlantActive { get; set; }

    }
}
