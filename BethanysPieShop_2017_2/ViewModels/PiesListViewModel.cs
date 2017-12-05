using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop_2017_2.Models;

namespace BethanysPieShop_2017_2.ViewModels
{
    
        public class PiesListViewModel
        {
            public IEnumerable<Pie> Pies { get; set; }
            public string CurrentCategory { get; set; }
        }
    
}
