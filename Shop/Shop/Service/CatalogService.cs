using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class CatalogService
    {        
            private static readonly CatalogService instance = new CatalogService();

            static CatalogService()
            {
            }

            private CatalogService()
            {
            }

            public static CatalogService Instance
            {
                get
                {
                    return instance;
                }
            }

            private Catalog _catalog = new Catalog();
                

            public void ShowCatalog()
            {
                _catalog.ShowCatalog();
            } 
    }
}
