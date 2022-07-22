using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class BorrowingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BorrowingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int id)
        {
            var vm = new BurrowViewModel
            {
                Books = await _unitOfWork.Books.GetAll(),
                MemberId = id
            };
            return View(vm);
        }

        public async Task<IActionResult> Borrow(int memberId, int bookId)
        {
            var borrow = new Borrowing { BookId = bookId, MemberId = memberId };
            return View(borrow);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrow(Borrowing borrow)
        {
            var member = await _unitOfWork.Members.Get(m => m.Id == borrow.MemberId);
            var book = await _unitOfWork.Books.Get(b => b.Id == borrow.BookId);
            if (member == null || book == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                borrow.DateBorrowed = DateTime.Now;
                await _unitOfWork.Borrowings.Insert(borrow);
                await _unitOfWork.Save();
                return RedirectToAction(actionName: "Details", controllerName: "ManageMembers", routeValues: new { id = borrow.MemberId });
            }
            return View(borrow);
        }
    }
}
