namespace Model.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_UserInfo
    {
        [Key]
        [StringLength(50)]
        public string User_ID { get; set; }

        [StringLength(50)]
        public string User_Code { get; set; }

        [StringLength(50)]
        public string User_Account { get; set; }

        [StringLength(50)]
        public string User_Pwd { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        public int? User_Sex { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Theme { get; set; }

        [StringLength(50)]
        public string Question { get; set; }

        [StringLength(50)]
        public string AnswerQuestion { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public string User_Remark { get; set; }
    }
}
