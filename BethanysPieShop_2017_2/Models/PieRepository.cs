using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop_2017_2.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> Pies => _appDbContext.Pies.Include(pie => pie.Category);
        public IEnumerable<Pie> PiesOfTheWeek => Pies.Where(p => p.IsPieOfTheWeek);
        public Pie GetPieById(int pieId)
        {
            return Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
