using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SettingServices
    {
        private readonly AppDbContext _context;

        public SettingServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, string>> GetSettings()
        {
            var data = await _context.Settings.ToDictionaryAsync(n => n.Key, n => n.Value);
            return data;
        }
    }
}
