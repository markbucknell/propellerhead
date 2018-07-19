using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Propellerhead.DataAccess;
using Propellerhead.Models;
using Propellerhead.ViewModels;

namespace Propellerhead.Controllers
{
    public class CustomersController : Controller
    {
        private Context db = new Context();

        // GET: Customers
        public ActionResult Index()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            customerViewModel.Customers = db.Customers.ToList();
            return View(customerViewModel);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CustomerDetailViewModel customerDetailViewModel = new CustomerDetailViewModel();
            Customer customer = db.Customers.Find(id);

            customerDetailViewModel.Active = customer.Active;
            customerDetailViewModel.CreatedDate = customer.CreatedDate;
            customerDetailViewModel.CustomerId = customer.CustomerId;
            customerDetailViewModel.Email = customer.Email;
            customerDetailViewModel.FirstName = customer.FirstName;
            customerDetailViewModel.LastName = customer.LastName;
            customerDetailViewModel.Mobile = customer.Mobile;
            customerDetailViewModel.ModifiedDate = customer.ModifiedDate;
            customerDetailViewModel.Status = customer.Status;
            customerDetailViewModel.Notes = customer.Notes;

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customerDetailViewModel);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,FirstName,LastName,Email,Mobile,Status,CreatedDate,ModifiedDate,Active")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CreatedDate = DateTime.Now;
                customer.ModifiedDate = DateTime.Now;
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
