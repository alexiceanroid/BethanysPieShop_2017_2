using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    
        public class PiesListViewModel
        {
            public IEnumerable<Pie> Pies { get; set; }

            public IEnumerable<Category> Categories
            {
                get
                {
                    var cats = new List<Category>();
                    foreach (var p in Pies)
                    {
                        if(!cats.Contains(p.Category))
                            cats.Add(p.Category);
                    }
                    return cats;
                }
            }
        }
    
}
