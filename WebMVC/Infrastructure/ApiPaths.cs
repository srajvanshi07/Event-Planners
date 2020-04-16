using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {
            public static string GetAllCatalogEvent(string baseUri,
                int page, int take)
            {
                //baseURL:-->localhost://6800/api/catalog, items-->pageparameter,pagesize
                return $"{baseUri}items?pageIndex={page}&pageSize={take}";
            }
        }
    }
}
