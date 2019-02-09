using Lab04.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class BatchesController : Controller
    {
        private ProdoctivityCaptureDBEntities db = new ProdoctivityCaptureDBEntities();

        // GET: Batches
        public ActionResult Index()
        {
            var batches = db.Batches.Include(b => b.BatchAssignment).Include(b => b.Workflow);
            return View(batches.ToList());
        }

        // GET: Batches/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batch batch = db.Batches.Find(id);
            if (batch == null)
            {
                return HttpNotFound();
            }
            return View(batch);
        }

        // GET: Batches/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.BatchAssignments, "BatchId", "Username");
            ViewBag.WorkflowId = new SelectList(db.Workflows, "Id", "Name");
            return View();
        }

        // POST: Batches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,WorkflowId,BatchStatus,CreationDate,Username,BatchPages,IsAssignedAsDocument")] Batch batch)
        {
            if (ModelState.IsValid)
            {
                db.Batches.Add(batch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.BatchAssignments, "BatchId", "Username", batch.Id);
            ViewBag.WorkflowId = new SelectList(db.Workflows, "Id", "Name", batch.WorkflowId);
            return View(batch);
        }

        // GET: Batches/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batch batch = db.Batches.Find(id);
            if (batch == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.BatchAssignments, "BatchId", "Username", batch.Id);
            ViewBag.WorkflowId = new SelectList(db.Workflows, "Id", "Name", batch.WorkflowId);
            return View(batch);
        }

        // POST: Batches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,WorkflowId,BatchStatus,CreationDate,Username,BatchPages,IsAssignedAsDocument")] Batch batch)
        {
            if (ModelState.IsValid)
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.BatchAssignments, "BatchId", "Username", batch.Id);
            ViewBag.WorkflowId = new SelectList(db.Workflows, "Id", "Name", batch.WorkflowId);
            return View(batch);
        }

        // GET: Batches/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batch batch = db.Batches.Find(id);
            if (batch == null)
            {
                return HttpNotFound();
            }
            return View(batch);
        }

        // POST: Batches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Batch batch = db.Batches.Find(id);
            db.Batches.Remove(batch);
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
