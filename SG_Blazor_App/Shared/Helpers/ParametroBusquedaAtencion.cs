using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_App.Shared.Helpers
{
    public class ParametroBusquedaAtencion
    {
        public ParametroBusquedaAtencion() 
        {
            FecIni = DateTime.Now.Date;
            FecFin= DateTime.Now.Date;
        }

        public DateTime FecIni { get; set; }
        public DateTime FecFin { get; set; }
        public string Dni { get; set; } = "";
        public string NomApe { get; set; } = "";
        public string tipExa { get; set; } = "";
        public string Empres { get; set; } = "";
        public string SubCon { get; set; } = "";
        public bool TodExa { get; set; } = false;
    }
}
