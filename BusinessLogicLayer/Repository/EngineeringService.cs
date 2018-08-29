using IBusinessLogicLayer.IRepository;
using IDAL;
using Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public partial class EngineeringService: BaseService<t_engineering>, IEngineeringService
    {
        private IEngineeringDal DAL = DALContainer.Container.Resolve<IEngineeringDal>();

        public override void SetDal()
        {
            Dal = DAL;
        }

        public List<t_engineering> GetAllList()
        {
            return this.DAL.context.t_engineering.ToList();
        }
    }
}
