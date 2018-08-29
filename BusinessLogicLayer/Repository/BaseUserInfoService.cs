using BusinessLogicLayer.Repository;
using IBusinessLogicLayer.IRepository;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using Model.DataModel;

namespace BusinessLogicLayer.Repository
{

    public partial class Base_UserInfoRepository : BaseService<Base_UserInfo>,IBase_UserInfoService
    {
        private IBase_UserInfoDal Base_UserInfoDal = DALContainer.Container.Resolve<IBase_UserInfoDal>();
        public override void SetDal()
        {
            Dal = Base_UserInfoDal;
        }
        /// <summary>
        /// 根据用户名获取信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public Base_UserInfo GetUserInfoByAccount(Base_UserInfo userInfo)
        {
            //var data = Base_UserInfoDal.GetModels(p => p.User_Account == userInfo.User_Account).FirstOrDefault();
            var data = Base_UserInfoDal.context.Base_UserInfo.Where(x => x.User_Account == userInfo.User_Account).FirstOrDefault();
            return data;
        }
    }
}
