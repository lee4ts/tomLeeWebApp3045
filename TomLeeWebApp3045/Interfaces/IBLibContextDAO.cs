using TomLeeWebApp3045.Models;

namespace TomLeeWebApp3045.Interfaces
{
    public interface IBLibContextDAO
    {
        List<BLib> GetAllBLibs();

        List<BLib> GetBLibsByIDs(List<int> ids);

        List<BLib> GetBLibsByName(string name);

        List<BLib> GetBLibsByCategory(string category);

        
    }
}