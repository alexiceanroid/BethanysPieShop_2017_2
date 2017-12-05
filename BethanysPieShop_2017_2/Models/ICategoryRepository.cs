using System.Collections.Generic;

namespace BethanysPieShop_2017_2.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}