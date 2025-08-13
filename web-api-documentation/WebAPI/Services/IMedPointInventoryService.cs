using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IMedPointInventoryService
    {
        List<MedCase> GetData();
        bool CreateMedCase(MedCase medCase);

        bool UpdateMedCase(MedCase medCase);

        bool DeleteMedCase(Guid medCaseKey);
    }
}
