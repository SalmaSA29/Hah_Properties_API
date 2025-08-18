using Microsoft.EntityFrameworkCore;
using PortalAPI.Models;
using PortalAPI.Models.InformationTechnology;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public class Items_Repository : Items_Interface
    {
        InformationTechnologyContext db;
        public Items_Repository(InformationTechnologyContext _db)
        {
            db = _db;
        }
        public async Task<VM_Resault> GetItems(string query)
        {
            if (db != null)
            {
                //List<ItmCat_Items> items = new List<ItmCat_Items>();
                //items = await db.ItmCat_Items.Include("Items_Attaches").Include("Category").Include("ItmCat_UOM")
                //    .Include("MatrialGroup").Include("MaterialType").Where(a => a.Item_Name == SAPCode).ToListAsync();

                var items = await db.ItmCat_Items
                                .AsNoTracking()
                                .Include(i => i.Items_Attaches)
                                .Include(i => i.Category)
                                .Include(i => i.ItmCat_UOM)
                                .Include(i => i.MatrialGroup)
                                .Include(i => i.MaterialType)
                                .Where(i => i.Item_Name.Contains(query) || i.Item_Desc.Contains(query))
                                .ToListAsync();


                if (items.Count > 0)
                {
                    return new VM_Resault()
                    {
                        code = (int)StatusCode.OK,
                        error = false,
                        message = null,
                        data = items.Cast<object>().ToList()
                    };
                }
                else
                {
                    return new VM_Resault()
                    {
                        code = (int)StatusCode.NoContent,
                        error = true,
                        message = "No Content"
                    };
                }
            }
            else
                return new VM_Resault()
                {
                    code = (int)StatusCode.ServiceUnAvailable,
                    error = true,
                    message = "Service Unavailable"
                };
        }
    }
}
