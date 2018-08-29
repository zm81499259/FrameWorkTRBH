using Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogicLayer.IRepository
{
    public partial interface IBase_UserInfoService : IBaseService<Base_UserInfo>
    {
        /// <summary>
        /// 根据用户名获取信息
        /// </summary>
        /// <returns></returns>
        Base_UserInfo GetUserInfoByAccount(Base_UserInfo userInfo);
    }
}
