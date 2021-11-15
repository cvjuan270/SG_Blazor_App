using SG_Blazor_App.Shared.Models.ConAte;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SG_Blazor_App.Shared.Models
{
    public partial class AtencionModel
    {
        [Key]
        public int IdAtenciones { get; set; }
        [StringLength(20)]
        public string? Local0 { get; set; }
        [StringLength(20)]
        public string? TipExa { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FecAte { get; set; }
        [StringLength(100),Required]
        public string? NomApe { get; set; }

        [StringLength(20),Required]
        public string? DocIde { get; set; }

        [StringLength(100)]
        public string? Empres { get; set; }
        [StringLength(100)]
        public string? SubCon { get; set; }
        [StringLength(100)]
        public string? Proyec { get; set; }
        [StringLength(100)]
        public string? Perfil { get; set; }
        [StringLength(100)]
        public string? Area { get; set; }
        [StringLength(100)]
        public string? PueTra { get; set; }
        [StringLength(50)]
        public string? PeReAd { get; set; }
        public TimeSpan? Hora { get; set; }
        public int? AleMed { get; set; }
        public int? AleAud { get; set; }
        public int? AleEnf { get; set; }
        public int? AlEnHc { get; set; }
        public ICollection<InterconsultaModel>  interconsultas { get; set; }

        public AtencionModel() 
        {
            this.interconsultas= new HashSet<InterconsultaModel>();
        }
    }
}
