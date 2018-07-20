namespace smartthingspanel.backend.Models.Entities
{
    public class Tile
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceValue { get; set; }
        public string Name { get; set; }
        public TileState State { get; set; }
    }
}