using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_App.Server.Data;
using SG_Blazor_App.Shared.Models.ConAte;

namespace SG_Blazor_App.Server.Controllers.ConAte
{
    [Route("api/interconsulta")]
    [ApiController]
    public class InterconsultaController : ControllerBase
    {
        private readonly AppDbContext db;

        public InterconsultaController( AppDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<InterconsultaModel>>> Get() 
        {
            return await db.interconsultas.ToListAsync();
        }

        [HttpGet]
        [Route("searchs")]
        public async Task<ActionResult<ICollection<InterconsultaModel>>> Getsearchs(int IdAtenciones)
        {


            List<InterconsultaModel>  interconsultas = new List<InterconsultaModel>();
            interconsultas= await db.interconsultas.Where(c=>c.IdAtenciones==IdAtenciones).ToListAsync();
            return interconsultas;
        }

        [HttpPost]
        public async Task<ActionResult<InterconsultaModel>> PostInterconsulta(List<InterconsultaModel> interconsultas) 
        {
            try
            {
               List<InterconsultaModel> lst = new List<InterconsultaModel>();
                foreach (var item in interconsultas)
                {
                    if (db.interconsultas.Contains(item))
                    {
                        db.Entry(item).State = EntityState.Modified;
                        lst.Add(item);

                    }
                }

                foreach (var item in lst)
                {
                    interconsultas.Remove(item);
                }
                if (interconsultas.Count>0)
                {
                    db.AddRange(interconsultas);
                }

                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                Console.WriteLine("guardarInterconsulta:" + ex.Message);
            }
            return null;
        }

    }
}
