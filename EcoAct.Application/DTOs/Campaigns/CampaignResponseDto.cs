

namespace EcoAct.Application.DTOs.Campaigns
{
    public class CampaignResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TargetTrees { get; set; }
        public int PlantedTrees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
