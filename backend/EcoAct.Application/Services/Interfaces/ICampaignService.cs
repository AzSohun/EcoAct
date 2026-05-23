using EcoAct.Application.DTOs.Campaigns;


namespace EcoAct.Application.Services.Interfaces
{
    public interface ICampaignService
    {
        Task<IEnumerable<CampaignResponseDto>> GetAllCampaignsAsync();
        Task<CampaignResponseDto?> GetCampaignByIdAsync(Guid id);
        Task<CampaignResponseDto> CreateCampaignAsync(CreateCampaignDto dto);
    }
}
