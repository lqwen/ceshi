using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();

        // GET: /Home/
        public ActionResult Index()
        {
            return View(db.cfgCategory.ToList());
        }

        // GET: /Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cfgCategory cfgcategory = db.cfgCategory.Find(id);
            if (cfgcategory == null)
            {
                return HttpNotFound();
            }
            return View(cfgcategory);
        }

        // GET: /Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Home/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Icon,Remark,ParentId,ParentIdList,Sort,State,CreateById,CreateBy,CreateDate,UpdateById,UpdateBy,UpdateDate,BelongId,BelongIds")] cfgCategory cfgcategory)
        {
            if (ModelState.IsValid)
            {
                db.cfgCategory.Add(cfgcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cfgcategory);
        }

        // GET: /Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cfgCategory cfgcategory = db.cfgCategory.Find(id);
            if (cfgcategory == null)
            {
                return HttpNotFound();
            }
            return View(cfgcategory);
        }

        // POST: /Home/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Icon,Remark,ParentId,ParentIdList,Sort,State,CreateById,CreateBy,CreateDate,UpdateById,UpdateBy,UpdateDate,BelongId,BelongIds")] cfgCategory cfgcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cfgcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cfgcategory);
        }

        // GET: /Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cfgCategory cfgcategory = db.cfgCategory.Find(id);
            if (cfgcategory == null)
            {
                return HttpNotFound();
            }
            return View(cfgcategory);
        }

        // POST: /Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cfgCategory cfgcategory = db.cfgCategory.Find(id);
            db.cfgCategory.Remove(cfgcategory);
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
