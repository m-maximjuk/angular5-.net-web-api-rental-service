﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Data.Context;
using Library.Entities;

namespace Server.Controllers
{
    public class ManufacturersController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Manufacturers
        public IQueryable<Manufacturer> GetManufacturers()
        {
            return db.Manufacturers;
        }

        // GET: api/Manufacturers/5
        [ResponseType(typeof(Manufacturer))]
        public async Task<IHttpActionResult> GetManufacturer(int id)
        {
            Manufacturer manufacturer = await db.Manufacturers.FindAsync(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        // PUT: api/Manufacturers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutManufacturer(int id, Manufacturer manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != manufacturer.ID)
            {
                return BadRequest();
            }

            db.Entry(manufacturer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Manufacturers
        [ResponseType(typeof(Manufacturer))]
        public async Task<IHttpActionResult> PostManufacturer(Manufacturer manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Manufacturers.Add(manufacturer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = manufacturer.ID }, manufacturer);
        }

        // DELETE: api/Manufacturers/5
        [ResponseType(typeof(Manufacturer))]
        public async Task<IHttpActionResult> DeleteManufacturer(int id)
        {
            Manufacturer manufacturer = await db.Manufacturers.FindAsync(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            db.Manufacturers.Remove(manufacturer);
            await db.SaveChangesAsync();

            return Ok(manufacturer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ManufacturerExists(int id)
        {
            return db.Manufacturers.Count(e => e.ID == id) > 0;
        }
    }
}