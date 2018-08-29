using BLLContainer;
using IBusinessLogicLayer.IRepository;
using Model.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //暖机操作，需要预热
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;

                var mappingCollection =
                            (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
                mappingCollection.GenerateViews(new List<EdmSchemaError>());
            }

            IBase_UserInfoService service = BusinessLogicLayerContainer.Resolve<IBase_UserInfoService>();
            Base_UserInfo userInfo = new Base_UserInfo() {
                User_Account="sa"
            };
            Console.WriteLine(DateTime.Now);
            var data = service.GetUserInfoByAccount(userInfo);
            var result = JsonConvert.SerializeObject(data);
            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
