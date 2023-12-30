using System.Threading.Tasks;

namespace GEPM_Tool.Services
{
    public interface IFirstRunDisplayService
    {
        Task ShowIfAppropriateAsync();
    }
}
