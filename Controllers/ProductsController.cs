using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MachineTest.Models;

namespace MachineTest.Controllers
{
    [Authorize]
    public class ProductsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Products
        public IQueryable<Products> GetProducts()
        {
            return db.Products;
        }

        //// GET: api/Products/5
        //[ResponseType(typeof(Products))]
        //public IHttpActionResult GetProducts(string sku)
        //{
        //    Products products = db.Products.Find(sku);
        //    if (products == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(products);
        //}


        public IHttpActionResult PutEnableAndDisable(string sku,bool status)
        {
            Products pro = db.Products.Find(sku);
            if (pro == null)
            {
                return BadRequest("Product sku is Invalid");
            }
            pro.Status = status;
            db.SaveChanges();

            return Ok(pro);

        }

      
        
        [ResponseType(typeof(Products))]
        public IHttpActionResult PostProducts(ProductAndInfo productsandinfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //;

            Products p = new Products();
            p.Product_Name = productsandinfo.Product_Name;
            p.Price = productsandinfo.Price;
            p.Qty = productsandinfo.Qty;
            p.Sku = productsandinfo.Sku;
            db.Products.Add(p);

            ProductInformation prod_info = new ProductInformation();
            prod_info.ProductId = productsandinfo.ProductId;
            prod_info.ProductCategory = productsandinfo.ProductCategory;
            prod_info.Description = productsandinfo.Description;

            db.ProductInformations.Add(prod_info);


            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductsExists(p.Sku)||ProductsInfoExists(prod_info.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok("product and its information saved in the database");
          
        }

        

        private bool ProductsExists(string id)
        {
            return db.Products.Count(e => e.Sku == id) > 0;
        }

        private bool ProductsInfoExists(int id)
        {
            return db.ProductInformations.Count(e => e.ProductId == id) > 0;
        }
    }
}