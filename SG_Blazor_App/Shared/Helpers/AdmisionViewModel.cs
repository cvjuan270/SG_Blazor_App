using SG_Blazor_App.Shared.Models;
using SG_Blazor_App.Shared.Models.ConAte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_App.Shared.Helpers
{
    public class AdmisionViewModel
    {
        public AtencionModel atencion { get; set; }
        public List<InterconsultaModel> interconsultas { get; set; }
        public AdmisionModel admision { get; set; }

        public AdmisionViewModel() 
        {
            atencion = new AtencionModel();
            interconsultas = new List<InterconsultaModel>();
            admision = new AdmisionModel();
        }
    }
}
