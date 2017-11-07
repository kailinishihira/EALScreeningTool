using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EALScreeningTool.Models
{
    [Table("DWLessThan150MSamples")]
    public class DWLessThan150MSample
    {
        [Key]
	
        public int DWLessThan150MId { get; set; }
        public DWLessThan150M DWLessThan150M { get; set; }

        public int SampleId { get; set; }
        public Sample Sample { get; set; }

		public decimal Result { get; set; }
		public bool ExceedsEAL { get; set; }

		public DWLessThan150MSample()
        {
        }
    }
}
