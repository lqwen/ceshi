//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class eqBeiTai_BloodSugar
    {
        public int Id { get; set; }
        public string Member_Id { get; set; }
        public string Result { get; set; }
        public Nullable<System.DateTime> Test_Time { get; set; }
        public double Fpg { get; set; }
        public byte Meal { get; set; }
        public string Did { get; set; }
        public Nullable<int> Dtype { get; set; }
        public string IdCard { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int BelongId { get; set; }
        public string BelongIds { get; set; }
    }
}
