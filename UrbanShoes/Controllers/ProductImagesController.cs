using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using UrbanShoes.DAL;
using UrbanShoes.Models;

namespace UrbanShoes.Controllers
{
    public class ProductImagesController : Controller
    {
        private MainStore db = new MainStore();

        // GET: ProductImages
        public ActionResult Index()
        {
            return View(db.ProductImages.ToList());
        }

        // GET: ProductImages/Details/5
   
     

        // POST: ProductImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null)
            {

                if(ValidateFile(file))
                {
                    try
                    {
                        SaveFileToDisk(file);
                    }
                    catch(Exception)
                    {

                    }
                }

                if(ModelState.IsValid)
                {
                    db.ProductImages.Add(new ProductImage { FileName = file.FileName });
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            
            }

            return View();
        }

   
    

        // POST: ProductImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
     

        // GET: ProductImages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductImage productImage = db.ProductImages.Find(id);
            if (productImage == null)
            {
                return HttpNotFound();
            }
            return View(productImage);
        }

        // POST: ProductImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductImage productImage = db.ProductImages.Find(id);
            db.ProductImages.Remove(productImage);
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
        private bool ValidateFile (HttpPostedFileBase file)
        {
            string fileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();
            string[] allowedFileTypes = { ".png", ".jpeg", "jpg", ".gif" };
            if ((file.ContentLength > 0 && file.ContentLength < 2091758) && allowedFileTypes.Contains(fileExtension))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SaveFileToDisk(HttpPostedFileBase file)
        {
            WebImage img = new WebImage(file.InputStream);
            if(img.Width > 190)
            {
                img.Resize(190, img.Height);

            }
            img.Save(Constants.ProductImagePath + file.FileName);
            if (img.Width > 100)
            {
                img.Resize(100, img.Height);

            }
            img.Save(Constants.ProductImagePath + file.FileName);
        }
    }
}
