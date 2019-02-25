using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LibraryData.Data.Interface;
using Library.Models.View_Model.Patron;
using Library.Models;
using System.Collections.Generic;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        private IPatron _patron;

        public PatronController(IPatron patron)
        {
            _patron = patron;
        }       

        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();
            var patronModels = allPatrons.Select(p=> new PatronDetailModel{
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                LibraryCardId = p.LibraryCard.Id,
                OverdueFees = p.LibraryCard.Fees,
                HomeLibrayBranch = p.HomeLibraryBranch.Name
            }).ToList();

            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patron = _patron.Get(id);
            var model = new PatronDetailModel
            {
                LastName = patron.LastName,
                FirstName = patron.FirstName,
                Address = patron.Address,
                HomeLibrayBranch = patron.HomeLibraryBranch.Name,
                MemberSince = patron.LibraryCard.Created,
                OverdueFees = patron.LibraryCard.Fees,
                LibraryCardId = patron.LibraryCard.Id,
                Telephone = patron.TelephoneNumber,
                AssetsCheckeout = _patron.GetCheckouts(id).ToList() ?? new List<Checkout>(),
                CheckoutHistory = _patron.GetCheckoutHistory(id),
                Holds = _patron.GetHolds(id)
            };

            return View(model);
        }
    }
}
