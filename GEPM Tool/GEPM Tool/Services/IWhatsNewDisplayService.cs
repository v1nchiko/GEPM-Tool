using System.Threading.Tasks;

namespace GEPM_Tool.Services
{
    public interface IWhatsNewDisplayService
    {
        Task ShowIfAppropriateAsync();
    }
}
