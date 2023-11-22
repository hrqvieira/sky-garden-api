using System.ComponentModel.DataAnnotations;

namespace sky_garden_api.src.Plants
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastWatering { get; set; }

        public string Status { get; set; }

        public string RoomName { get; set; }

        public string DesignatedWatering { get; set; }
    }
}
