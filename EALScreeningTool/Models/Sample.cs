using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EALScreeningTool.Models
{
    [Table("Samples")]
    public class Sample
    {
        [Key]
        public int SampleId { get; set; }
        public int ProjectSampleId { get; set; }
        public string MediaType { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime CollectionTime { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal SampleDepth { get; set; }
        public decimal DepthToGW { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public List<DWLessThan150MSample> DWLessThan150MSamples { get; set; }

        public Sample()
        {
        }
    }
}
