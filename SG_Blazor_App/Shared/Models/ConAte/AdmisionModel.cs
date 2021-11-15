using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_App.Shared.Models.ConAte
{
    public class AdmisionModel
    {

        [Key]
        public int IdAdmi { get; set; }

        public int IdAtenciones { get; set; }

        [ForeignKey("IdAtenciones")]
        public virtual AtencionModel? atencion { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Hora de ingreso")]
        public DateTime? HorIng { get; set; } = new DateTime();

        [DataType(DataType.Time)]
        [Display(Name = "Hora de Registro")]
        public DateTime? HorReg { get; set; } = new DateTime();

        [DataType(DataType.Time)]
        [Display(Name = "Hora de salida")]
        public DateTime? HorSal { get; set; } = new DateTime();

        [StringLength(200)]
        [Display(Name = "Pendientes")]
        public string Pendie { get; set; }

        [Display(Name = "Envio de asistencia")]
        public bool EnvAsi { get; set; }

        [Display(Name = "Envio de aptitud")]
        public bool EnvApt { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fech. envio de resultados a medicina")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FecEnvResMed { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Fech. envio de resultados a Empresa")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FecEnvResEmp { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

       

    }
}
