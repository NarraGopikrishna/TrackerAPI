﻿using System;
using System.Collections.Generic;

namespace DomainLayer.Table_Entities
{
    public partial class TblProjects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectTeamLead { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectKey { get; set; }
        public string ProjectType { get; set; }
        public string ProjectLogo { get; set; }
        public bool? ProjectStatus { get; set; }
        public DateTime ProjectCreatedOn { get; set; }
        public string ProjectCreatedBy { get; set; }
        public DateTime? ProjectUpdatedOn { get; set; }
        public string ProjectUpdatedBy { get; set; }
    }
}
