namespace Model.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
        }

        public virtual DbSet<Base_UserInfo> Base_UserInfo { get; set; }
        public virtual DbSet<t_engineering> t_engineering { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_Pwd)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.AnswerQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserInfo>()
                .Property(e => e.User_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.dwgcbh)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.dwmc)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.gcmc)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.zdwmc)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.gcmm)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.gczt)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.qyxz)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.xxdz)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.yzbm)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.lxdh)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.wtr1)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.wtr2)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.wtr3)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.bgdgs)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.cz)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.http)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.gclb)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jsdd)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jzmj)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.dscs)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.dxcs)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.fkfs)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jsdw)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.sgdw)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jldw)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.sfjz)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.LXR1)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.LXR2)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.beizhu)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.SGDD)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.LXR3)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.zhuangtai)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.dwbh02)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.xjr)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.xgr)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.zb)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.tzdwexp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jldwexp)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.hntzlexp)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jhgqexp)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.hntjsyqtdexp)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.gyggchntqyexp)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.sydw)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.jzr)
                .IsUnicode(false);

            modelBuilder.Entity<t_engineering>()
                .Property(e => e.sgdd02)
                .IsUnicode(false);
        }
    }
}
