using Autofac;
using DAL.RepositoryDal;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALContainer
{
    /// <summary>
    /// 容器
    /// </summary>
    public class Container
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        public static IContainer container = null;

        /// <summary>
        /// 获取 IDal 的实例化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("IOC实例化出错!" + ex.Message);
            }

            return container.Resolve<T>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            var IDal = Assembly.Load("IDAL");
            var Dal = Assembly.Load("DAL");
            //程序集注入
            builder.RegisterAssemblyTypes(IDal, Dal).Where(t => t.Name.EndsWith("DAL")).AsImplementedInterfaces();
            //格式：builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
            //builder.RegisterType<Base_UserInfoDAL>().As<IBase_UserInfoDal>().InstancePerLifetimeScope();
            //builder.RegisterType<EngineeringDAL>().As<IEngineeringDal>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
