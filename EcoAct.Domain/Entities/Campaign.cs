using System;
using System.Collections.Generic;
using System.Text;

namespace EcoAct.Domain.Entities
{
    public class Campaign
    {
        public Guid id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Despcription { get; set; } = string.Empty;
        public int TargetTrees { get; set; }
        public int PlantedTree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
