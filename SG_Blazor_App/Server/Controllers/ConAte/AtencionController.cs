using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_App.Server.Data;
using SG_Blazor_App.Shared.Models;

namespace SG_Blazor_App.Server.Controllers.ConAte
{
    [Route("api/atencion")]
    [ApiController]
    public class AtencionController : ControllerBase
    {
        private readonly AppDbContext db;

        public AtencionController(AppDbContext context) { db = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AtencionModel>>> Get(string FecIni, string FecFin, string? Dni, string? NomApe
            , string? TipExa, string? Empres, string? SubCon,string? TodExa)
        {
            var _FecIni = DateTime.Parse(FecIni);
            var _FecFin = DateTime.Parse(FecFin);
            /*Query por fechas*/
            var query = db.Atenciones.Where(c => c.FecAte >= _FecIni && c.FecAte <= _FecFin);

            /*validar parametros vacios o nulos*/
            if (!String.IsNullOrEmpty(Dni)) 
            {
                query= query.Where(c => c.DocIde.Contains(Dni));
            }
            if (!String.IsNullOrEmpty(NomApe)) 
            {
                query = query.Where(c => c.NomApe.Contains(NomApe));
            }
            if (!String.IsNullOrEmpty(Empres))
            {
                query = query.Where(c => c.Empres.Contains(Empres));
            }
            if (!String.IsNullOrEmpty(TipExa))
            {
                query = query.Where(c => c.TipExa.Contains(TipExa));
            }
            if (!string.IsNullOrEmpty(SubCon))
            {
                query = query.Where(c => c.SubCon.Contains(SubCon));
            }
            if (TodExa=="False") 
            {
                query = query.Where(c => c.TipExa != "OTROS");
            }

            return await query.ToListAsync();
        }
    }
}
