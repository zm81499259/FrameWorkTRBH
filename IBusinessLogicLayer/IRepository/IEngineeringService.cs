using Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogicLayer.IRepository
{
    public partial interface IEngineeringService:IBaseService<t_engineering>
    {
        List<t_engineering> GetAllList();
    }
}
