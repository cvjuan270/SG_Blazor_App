using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_App.Shared.Models
{
    public class EspecialidadMedicaModel
    {
        [Key]
        public int IdEspeMedic { get; set; }
        public String Especialidad { get; set; }
    }
}
