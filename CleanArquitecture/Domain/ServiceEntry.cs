namespace CleanArquitecture.Domain
{
    public class ServiceEntry
    {
        public int Id { get; set; }
        public Device Device { get; set; } = new();
        public string CustomerName { get; set; } = string.Empty;
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        public ServiceStatus Status { get; set; } = ServiceStatus.Received;
    }
}
