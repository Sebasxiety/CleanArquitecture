using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.UseCases;
using CleanArquitecture.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanArquitecture.Controllers
{
    public class EntryController : Controller
    {
        private readonly RegisterEntryUseCase _registerEntryUseCase;
        private readonly IServiceEntryRepository _repository;

        public EntryController(RegisterEntryUseCase registerEntryUseCase, IServiceEntryRepository repository)
        {
            _registerEntryUseCase = registerEntryUseCase;
            _repository = repository;
        }

        public IActionResult Index()
        {
            var entries = _repository.GetAll();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ServiceEntry entry)
        {
            if (ModelState.IsValid)
            {
                _registerEntryUseCase.Execute(entry);
                return RedirectToAction("Index");
            }
            return View(entry);
        }
    }
}
