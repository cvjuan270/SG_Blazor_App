using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_App.Server.Data;
using SG_Blazor_App.Shared.Models.ConAte;

namespace SG_Blazor_App.Server.Controllers.ConAte
{
    [Route("api/admision")]
    [ApiController]
    public class AdmisionController : ControllerBase
    {
        private readonly AppDbContext db;

        public AdmisionController(AppDbContext appDbContext)
        {
            db = appDbContext;
        }


        [HttpGet]
        public async Task<ActionResult<ICollection<AdmisionModel>>> Getlist() 
        {
            return await db.admisions.ToListAsync();
        }

        [HttpGet, Route("searchs")]
        public async Task<ActionResult<AdmisionModel>> Get(int IdAtenciones)
        {
            var admision = new AdmisionModel();
            var query = db.admisions.Where(c => c.IdAtenciones == IdAtenciones);
            if (query.Count() > 0)
            {
                return await query.FirstOrDefaultAsync();
            }
            else
            {
                return admision;
            }

        }

        [HttpPost]
        public async Task<ActionResult<AdmisionModel>> PostAdmision(AdmisionModel admision)
        {
            db.admisions.Add(admision);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetAdmisionModel", new { id = admision.IdAdmi }, admision);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmision(int id, AdmisionModel admision)
        {
            if (id != admision.IdAdmi)
            {
                return BadRequest();
            }
            db.Entry(admision).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdenAtencionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool OrdenAtencionExists(int id)
        {
            return db.admisions.Any(e => e.IdAdmi == id);
        }
    }
}
