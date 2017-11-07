using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EALScreeningTool.Models
{
    [Table("DWLessThan150Ms")]
    public class DWLessThan150M
    {
        [Key]
        public int DWLessThan150MId { get; set; }
        public string Contaminant { get; set; }
        public decimal SoilEAL { get; set; }
        public decimal GroundwaterEAL { get; set; }

		public List<DWLessThan150MSample> DWLessThan150MSamples { get; set; }

		public DWLessThan150M()
        {
        }
    }
}
