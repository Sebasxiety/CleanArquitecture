using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Domain;

namespace CleanArquitecture.Application.UseCases
{
    public class RegisterEntryUseCase
    {
        private readonly IServiceEntryRepository _repository;

        public RegisterEntryUseCase(IServiceEntryRepository repository)
        {
            _repository = repository;
        }

        public void Execute(ServiceEntry entry)
        {
            _repository.Add(entry);
        }
    }
}
