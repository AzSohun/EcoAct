using System;
using System.Collections.Generic;
using System.Text;

namespace EcoAct.Application.DTOs.Campaigns
{
    public class CreateCampaignDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TargetTrees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
