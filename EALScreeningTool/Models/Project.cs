using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EALScreeningTool.Models
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string TMK { get; set; }
        public string LandUse { get; set; }
        public string GWUtility { get; set; }
        public string DistanceToWB { get; set; }

        public ICollection<Sample> Samples { get; set; }

        public virtual ApplicationUser User { get; set; }

        public Project()
        {
        }
    }
}
