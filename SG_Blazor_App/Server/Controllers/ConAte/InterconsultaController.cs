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
            return await db.interconsultas.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<InterconsultaModel>> PostInterconsulta(List<InterconsultaModel> interconsultas) 
        {

            db.interconsultas.AddRange(interconsultas);
            db.SaveChanges();
            return null;
        }

    }
}
