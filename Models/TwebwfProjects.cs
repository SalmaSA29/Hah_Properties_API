using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models
{
    public partial class TwebwfProjects
    {
        [Key]
        public int ProjectId { get; set; }
        public int? Unit_group { get; set; }
        public string Unit { get; set; }
        public int? ProTypId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectDirector { get; set; }
        public string ProjectsDirector { get; set; }
        public string ProjectAdmin { get; set; }
        public string HrCoordinator { get; set; }
        public string HrSectionHead { get; set; }
        public string HR_Administration { get; set; }
        public string HR_Administration2 { get; set; }
        public string HrAssWages { get; set; }
        public string HR_AssWages2 { get; set; }
        public int? SubGroupId { get; set; }
        public int? GroupPolicyId { get; set; }
        public int? AreaId { get; set; }
        public int? WorkDays { get; set; }
        public byte? Status { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public bool? IsPhotoGallery { get; set; }
        public string PhotoGallery_Name { get; set; }
        public DateTime? LastDateOfUpdate { get; set; }
        public bool? IsFingerPrint { get; set; }
    }
}
