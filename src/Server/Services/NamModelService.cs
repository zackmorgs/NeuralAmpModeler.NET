using Server.Data;

namespace Server.Services
{
    public class NamModelService
    {
        public NamModelService(NAMDb context) {
            _context = context;
        }

        private readonly NAMDb _context;
    }
}
