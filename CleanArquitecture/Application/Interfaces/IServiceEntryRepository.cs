using CleanArquitecture.Domain;

namespace CleanArquitecture.Application.Interfaces
{
    public interface IServiceEntryRepository
    {
        void Add(ServiceEntry entry);
        IEnumerable<ServiceEntry> GetAll();
    }
}
