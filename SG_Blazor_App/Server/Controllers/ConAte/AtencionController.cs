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
        public async Task<ActionResult<IEnumerable<AtencionModel>>> Get() 
        {
            var date = DateTime.Now;
            return await db.Atenciones.Where(c=>c.FecAte == date).ToListAsync();
        }
    }
}
