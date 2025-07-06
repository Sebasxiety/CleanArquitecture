namespace CleanArquitecture.Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Imei { get; set; } = string.Empty;
    }
}
