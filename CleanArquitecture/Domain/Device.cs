using System.Text.Json;

namespace CleanArquitecture.Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Imei { get; set; } = string.Empty;
        public Device(int id, string brand, string model, string imei)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Imei = imei;
        }
        public Device() { }
    }
    public class DeviceSerializer
    {
        public string ToJson(Device device)
        {
            return JsonSerializer.Serialize(device);
        }

        public Device FromJson(string json)
        {
            return JsonSerializer.Deserialize<Device>(json)!;
        }
    }
}
