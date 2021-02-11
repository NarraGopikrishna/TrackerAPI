﻿using System;
using System.Collections.Generic;

namespace DomainLayer.Table_Entities
{
    public partial class TblProjectIssues
    {
        public int IssueId { get; set; }
        public int IssueProjectId { get; set; }
        public string IssueHeading { get; set; }
        public string IssueDescription { get; set; }
        public int IssueStatusId { get; set; }
        public int IssuePriorityId { get; set; }
        public string IssueAssignee { get; set; }
        public string IssueReporter { get; set; }
        public string IssueType { get; set; }
        public string IssueEstimatedTime { get; set; }
        public string IssueTimeStarts { get; set; }
        public string IssueModule { get; set; }
        public string IssueComments { get; set; }
        public DateTime IssueCreatedOn { get; set; }
        public string IssueCreatedBy { get; set; }
        public DateTime? IssueUpdatedOn { get; set; }
        public string IssueUpdatedBy { get; set; }
    }
}
