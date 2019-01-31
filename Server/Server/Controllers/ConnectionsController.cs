using System;
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
using Library.Enums;

namespace Server.Controllers
{
    public class ConnectionsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Connections
        public IQueryable<Connection> GetConnections()
        {
            return db.Connections;
        }

        // GET: api/Connections/5
        [ResponseType(typeof(Connection))]
        public async Task<IHttpActionResult> GetConnection(int id)
        {
            Connection connection = await db.Connections.FindAsync(id);
            if (connection == null)
            {
                return NotFound();
            }

            return Ok(connection);
        }

        // PUT: api/Connections/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutConnection(int id, Connection connection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != connection.ID)
            {
                return BadRequest();
            }

            db.Entry(connection).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConnectionExists(id))
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

        // POST: api/Connections
        [ResponseType(typeof(Connection))]
        public async Task<IHttpActionResult> PostConnection(Connection connection)
        {
            var request = new Account() { Username = connection.Username, Password = connection.Password };
            var result = await new Data.Services.Validations().AccountCheck(request);
            if (result.Key == DataResult.Success)
            {
                this.db.Connections.Add(connection);
                await this.db.SaveChangesAsync();
                return Json(result.Value);
            }
            else
            {
                if (result.Key == DataResult.InvalidUsername) { return BadRequest($"Invalid Username"); }
                if (result.Key == DataResult.InvalidPassword) { return BadRequest(MyEnum<DataResult>.Stringify(result.Key)); }
                return BadRequest("Account Not Found");
            }
        }

        // DELETE: api/Connections/5
        [ResponseType(typeof(Connection))]
        public async Task<IHttpActionResult> DeleteConnection(int id)
        {
            Connection connection = await db.Connections.FindAsync(id);
            if (connection == null)
            {
                return NotFound();
            }

            db.Connections.Remove(connection);
            await db.SaveChangesAsync();

            return Ok(connection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConnectionExists(int id)
        {
            return db.Connections.Count(e => e.ID == id) > 0;
        }
    }
}