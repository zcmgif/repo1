//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flowers.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        public int GId { get; set; }
        public string Gpicture { get; set; }
        public string Gname { get; set; }
        public Nullable<decimal> GOprice { get; set; }
        public Nullable<decimal> Gprice { get; set; }
        public string GFree { get; set; }
        public string Gintroduce { get; set; }
        public Nullable<double> Gnumber { get; set; }
        public Nullable<double> GpNum { get; set; }
        public Nullable<int> SId { get; set; }
        public Nullable<int> MenuID { get; set; }
        public string bigImgUrl { get; set; }
    }
}