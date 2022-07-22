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

namespace Biblioteca.Controllers
{
    public class ManageMembersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManageMembersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: ManageMembers
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.Members.GetAll());

        }

        // GET: ManageMembers/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var member = await _unitOfWork.Members.Get(b => b.Id == id,includes: new List<string> { "Borrowings", "Borrowings.Book" });
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: ManageMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ManageMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Members.Insert(member);
                await _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: ManageMembers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var member = await _unitOfWork.Members.Get(b => b.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: ManageMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Members.Update(member);
                    await _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var b = await _unitOfWork.Members.Get(b => b.Id == id);

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
            return View(member);
        }

        // GET: ManageMembers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var member = await _unitOfWork.Members.Get(b => b.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: ManageMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var member = await _unitOfWork.Members.Get(b => b.Id == id);
            if (member != null)
            {
                await _unitOfWork.Members.Delete(id);
                await _unitOfWork.Save();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
