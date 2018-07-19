using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Propellerhead.DataAccess;
using Propellerhead.Models;
using Propellerhead.ViewModels;

namespace Propellerhead.Controllers
{
    public class NotesController : Controller
    {
        private Context db; // = new Context();

        public NotesController()
        {
            db = new Context();
        }

        // GET: Notes
        public ActionResult Index()
        {
            return View(db.Notes.ToList());
        }

        // GET: Notes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Note note = db.Notes.Find(id);
            if (note == null)
            {
                return HttpNotFound();
            }
            return View(note);
        }

        // GET: Notes/Create
        public ActionResult Create(int id)
        {
            NoteDetailViewModel noteDetailViewModel = new NoteDetailViewModel();
            noteDetailViewModel.CustomerId = id;
            noteDetailViewModel.Active = true;
            noteDetailViewModel.CreatedDate = DateTime.Now;
            noteDetailViewModel.ModifiedDate = DateTime.Now;
            
            return View(noteDetailViewModel);
        }

        // POST: Notes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoteId,Value,CreatedDate,ModifiedDate,Active,CustomerId")] NoteDetailViewModel noteDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                Note note = new Note();
                note.Value = noteDetailViewModel.Value;
                note.CreatedDate = DateTime.Now;
                note.ModifiedDate = DateTime.Now;
                note.Active = true;
                note.Customer = db.Customers.Find(noteDetailViewModel.CustomerId);
                db.Notes.Add(note);
                db.SaveChanges();
                return RedirectToAction("Edit", "Customers", new { id = note.Customer.CustomerId } );
            }

            return View(noteDetailViewModel);
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Note note = db.Notes.Find(id);
            if (note == null)
            {
                return HttpNotFound();
            }
            return View(note);
        }

        // POST: Notes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoteId,Value,CreatedDate,ModifiedDate,Active,CustomerId")] NoteDetailViewModel noteDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                Note note = db.Notes.Find(noteDetailViewModel.NoteId);
                note.Value = noteDetailViewModel.Value;
                note.ModifiedDate = DateTime.Now;
                db.Entry(note).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "Customers", new { id = note.Customer.CustomerId });
            }
            return View(noteDetailViewModel);
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Note note = db.Notes.Find(id);
            if (note == null)
            {
                return HttpNotFound();
            }
            return View(note);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Note note = db.Notes.Find(id);
            db.Notes.Remove(note);
            db.SaveChanges();
            return RedirectToAction("Index");
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
