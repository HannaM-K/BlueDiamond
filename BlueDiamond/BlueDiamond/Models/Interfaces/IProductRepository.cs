using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models.Interfaces
{
    public interface IProductRepository
    {
        List<Product> Products { get;}
    }
}
