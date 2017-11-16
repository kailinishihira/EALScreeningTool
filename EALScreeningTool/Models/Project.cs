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
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string SiteName { get; set; }
        [Required]
        public string SiteAddress { get; set; }
        [Required]
        public string TMK { get; set; }
        [Required]
        public string LandUse { get; set; }
        [Required]
        public string GWUtility { get; set; }
        [Required]
        public string DistanceToWB { get; set; }

        public ICollection<Sample> Samples { get; set; }

        public virtual ApplicationUser User { get; set; }

        public Project()
        {
        }

    }
}
