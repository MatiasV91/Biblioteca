using Biblioteca.Helpers;
using Biblioteca.Models;
using Biblioteca.Models.Filters;
using Biblioteca.Models.ViewModels;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    [Authorize]
    public class BorrowingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BorrowingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int id,BooksFilters filters)
        {
            var vm = new BorrowViewModel
            {
                Books = await _unitOfWork.Books.GetFilteredBooks(filters),
                MemberId = id,
                Filters = filters
            };
            return View(vm);
        }

        public async Task<IActionResult> Borrow(int memberId, int bookId)
        {
            var member = await _unitOfWork.Members.Get(m => m.Id == memberId);
            var book = await _unitOfWork.Books.Get(b => b.Id == bookId);
            if (member == null || book == null)
            {
                return NotFound();
            }
            var borrow = new Borrowing { Member = member, Book = book, BookId = bookId, MemberId = memberId };
            return View(borrow);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borrow(Borrowing borrow)
        {
            var book = await _unitOfWork.Books.Get(b => b.Id == borrow.BookId);
            if (book.CopiesAvailable == 0)
            {
                ModelState.AddModelError("", "No Copies Available to Borrow");
            }

            if (await _unitOfWork.Books.HasUnreturnedBook(borrow.MemberId,borrow.BookId))
            {
                ModelState.AddModelError("", "The Book Has already been borrowed and wasn't returned");
            }

            if (ModelState.IsValid)
            {
                borrow.DateBorrowed = DateTime.Now;
                --book.CopiesAvailable;
                _unitOfWork.Books.Update(book);
                await _unitOfWork.Borrowings.Insert(borrow);
                await _unitOfWork.Save();
                return RedirectToAction(actionName: "Details", controllerName: "ManageMembers", routeValues: new { id = borrow.MemberId });
            }
            return View(borrow);
        }

        public async Task<IActionResult> Return(int id)
        {
            var borrowing = await _unitOfWork.Borrowings.Get(b => b.Id == id, new List<string> { "Member", "Book" });
            if (borrowing == null)
            {
                return NotFound();
            }
            borrowing.DateReturned = DateTime.Now;
            borrowing.CalculateFine();
            return View(borrowing);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Return(Borrowing borrow)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Borrowings.Update(borrow);
                var book = await _unitOfWork.Books.Get(b => b.Id == borrow.BookId);
                ++book.CopiesAvailable;
                _unitOfWork.Books.Update(book);
                await _unitOfWork.Save();
                return RedirectToAction(actionName: "Details", controllerName: "ManageMembers", routeValues: new { id = borrow.MemberId });
            }
            return View(borrow);
        }


    }
}
