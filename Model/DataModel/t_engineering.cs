namespace Model.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_engineering
    {
        [Key]
        [StringLength(50)]
        public string dwgcbh { get; set; }

        [StringLength(100)]
        public string dwmc { get; set; }

        [StringLength(100)]
        public string gcmc { get; set; }

        [StringLength(100)]
        public string zdwmc { get; set; }

        [StringLength(50)]
        public string gcmm { get; set; }

        [StringLength(50)]
        public string gczt { get; set; }

        [StringLength(50)]
        public string qyxz { get; set; }

        [StringLength(100)]
        public string xxdz { get; set; }

        [StringLength(50)]
        public string yzbm { get; set; }

        [StringLength(50)]
        public string lxdh { get; set; }

        [StringLength(50)]
        public string wtr1 { get; set; }

        [StringLength(50)]
        public string wtr2 { get; set; }

        [StringLength(50)]
        public string wtr3 { get; set; }

        [StringLength(50)]
        public string bgdgs { get; set; }

        [StringLength(50)]
        public string cz { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string http { get; set; }

        [StringLength(50)]
        public string gclb { get; set; }

        [StringLength(100)]
        public string jsdd { get; set; }

        public DateTime? kgrq { get; set; }

        public DateTime? jgrq { get; set; }

        [StringLength(50)]
        public string jzmj { get; set; }

        [StringLength(50)]
        public string dscs { get; set; }

        [StringLength(50)]
        public string dxcs { get; set; }

        [StringLength(50)]
        public string fkfs { get; set; }

        public double? yjsl { get; set; }

        [StringLength(100)]
        public string jsdw { get; set; }

        [StringLength(100)]
        public string sgdw { get; set; }

        [StringLength(100)]
        public string jldw { get; set; }

        [StringLength(50)]
        public string sfjz { get; set; }

        [StringLength(50)]
        public string LXR1 { get; set; }

        [StringLength(50)]
        public string LXR2 { get; set; }

        [StringLength(200)]
        public string beizhu { get; set; }

        public double? YSJL { get; set; }

        [StringLength(70)]
        public string SGDD { get; set; }

        [StringLength(50)]
        public string LXR3 { get; set; }

        [StringLength(50)]
        public string zhuangtai { get; set; }

        public DateTime? xjrq { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(20)]
        public string dwbh02 { get; set; }

        [StringLength(20)]
        public string xjr { get; set; }

        [StringLength(20)]
        public string xgr { get; set; }

        [StringLength(50)]
        public string zb { get; set; }

        [StringLength(50)]
        public string tzdwexp { get; set; }

        [StringLength(50)]
        public string jldwexp { get; set; }

        [StringLength(50)]
        public string hntzlexp { get; set; }

        public DateTime? kgrqexp { get; set; }

        [StringLength(50)]
        public string jhgqexp { get; set; }

        [StringLength(70)]
        public string hntjsyqtdexp { get; set; }

        [StringLength(70)]
        public string gyggchntqyexp { get; set; }

        [StringLength(50)]
        public string sydw { get; set; }

        [StringLength(50)]
        public string jzr { get; set; }

        [StringLength(50)]
        public string sgdd02 { get; set; }

        public int DeleteMark { get; set; }
    }
}
