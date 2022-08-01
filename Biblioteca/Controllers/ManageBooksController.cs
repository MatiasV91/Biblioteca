using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;
using Biblioteca.Repositories;
using Biblioteca.Models.ViewModels;
using Biblioteca.Models.Filters;
using Microsoft.AspNetCore.Authorization;

namespace Biblioteca.Controllers
{
    [Authorize]
    public class ManageBooksController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManageBooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: ManageBooks
        public async Task<IActionResult> Index(BooksFilters filters)
        {
            var vm = new BooksIndexViewModel
            {
                Books = await _unitOfWork.Books.GetFilteredBooks(filters),
                Filters = filters
            };
            return View(vm);
        }

        // GET: ManageBooks/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var book = await _unitOfWork.Books.Get(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: ManageBooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ManageBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Books.Insert(book);
                await _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: ManageBooks/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _unitOfWork.Books.Get(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: ManageBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Books.Update(book);
                    await _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var b = await _unitOfWork.Books.Get(b => b.Id == id);

                    if (b != null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: ManageBooks/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _unitOfWork.Books.Get(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: ManageBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var book = await _unitOfWork.Books.Get(b => b.Id == id);
            if (book != null)
            {
                await _unitOfWork.Books.Delete(id);
                await _unitOfWork.Save();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
