using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SG_Blazor_App.Server.Data;
using SG_Blazor_App.Shared.Models;

namespace SG_Blazor_App.Server.Controllers.ConAte
{
    [Route("api/especialidadmedica")]
    [ApiController]
    public class EspecialidadMedicacontroller : ControllerBase
    {
        private readonly AppDbContext db;

        public EspecialidadMedicacontroller(AppDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<EspecialidadMedicaModel>>> GetLst()
        {
            return await db.especialidadMedica.ToListAsync();
        }

        [HttpPost]
        public async Task PostEspecialidadMedica(EspecialidadMedicaModel model)
        {
            db.especialidadMedica.Add(model);
            await db.SaveChangesAsync();
        }
    }
}
