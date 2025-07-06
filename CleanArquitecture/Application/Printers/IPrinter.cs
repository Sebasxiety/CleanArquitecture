using CleanArquitecture.Domain;

namespace CleanArquitecture.Application.Printers
{
    public interface IPrinter
    {
        void Print(Device device);
    }
}
