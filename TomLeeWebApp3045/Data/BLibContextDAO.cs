using TomLeeWebApp3045.Interfaces;
using TomLeeWebApp3045.Models;

namespace TomLeeWebApp3045.Data
{
    public class BLibContextDAO : IBLibContextDAO
    {
        private BLibContext _context;
        public BLibContextDAO(BLibContext context)
        {
            _context = context;
        }

        public List<BLib> GetAllBLibs()
        {
            return _context.UserLib.ToList();
        }

        public List<BLib> GetBLibsByIDs(List<int> ids)
        {
            try
            {
                return _context.UserLib.Where(b => ids.Contains(b.Id)).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("An error occurred while retrieving BLibs by IDs.", ex);
            }
        }

        public List<BLib> GetBLibsByName(string name)
        {
            try
            {
                return _context.UserLib.Where(b => b.Name.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("An error occurred while retrieving BLibs by name.", ex);
            }
        }

        public List<BLib> GetBLibsByCategory(string category)
        {
            try
            {
                return _context.UserLib.Where(b => b.Category == category).ToList();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("An error occurred while retrieving BLibs by category.", ex);
            }
        }
    }
}