using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Services
{
    public interface ICatalogService
    {
        Task<>GetCatalogEventAsync(int page,int size)
    }
}
