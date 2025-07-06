using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Domain;

namespace CleanArquitecture.Infrastructure.Repositories
{
    public class InMemoryServiceEntryRepository : IServiceEntryRepository
    {
        private readonly List<ServiceEntry> _entries = new();
        private int _nextId = 1;

        public void Add(ServiceEntry entry)
        {
            entry.Id = _nextId++;
            _entries.Add(entry);
        }

        public IEnumerable<ServiceEntry> GetAll()
        {
            return _entries;
        }
    }
}
