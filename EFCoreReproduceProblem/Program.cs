using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreReproduceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add a new item  
            using (var dbContext = new demoContext())
            {
                var item = dbContext.Set<item>().Find("ItemGID");
                if (item == null)
                {
                    var addItem = new item();
                    addItem.ItemGID = "ItemGID";
                    addItem.itemDetail = new List<itemDetail>() { new itemDetail {
                     GUID ="GUID",
                 ItemGID = "ItemGID"} };
                    dbContext.Set<item>().Add(addItem);
                    dbContext.SaveChanges();
                }
            }


            using (var dbContext = new demoContext())
            {
                // remove the item and itemDetail
                IEnumerable<item> items = dbContext.Set<item>().Where(a => a.ItemGID == "ItemGID").AsEnumerable();
                dbContext.Set<item>().RemoveRange(items);

                IEnumerable<itemDetail> itemDestails = dbContext.Set<itemDetail>().Where(a => a.ItemGID == "ItemGID").AsEnumerable();
                dbContext.Set<itemDetail>().RemoveRange(itemDestails);

                //ReAdd the item and itemDetail
                item item = new item { ItemGID = "ItemGID", itemDetail = new List<itemDetail> { new itemDetail { ItemGID = "ItemGID", GUID = "GUID" } } };
                dbContext.Set<item>().Add(item);

                //in Framework EF , this count value is 1 , but in netcore this is 2
                Console.WriteLine(item.itemDetail.Count);
            }
        }

    }
}
