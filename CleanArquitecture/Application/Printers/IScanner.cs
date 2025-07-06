using CleanArquitecture.Domain;

namespace CleanArquitecture.Application.Printers
{
    public interface IScanner
    {
        void Scan(Device device);
    }
}
