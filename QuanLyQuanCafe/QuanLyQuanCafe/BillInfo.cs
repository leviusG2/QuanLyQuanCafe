//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanCafe
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillInfo
    {
        public int id { get; set; }
        public int idBill { get; set; }
        public int idFD { get; set; }
        public int count { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual FD FD { get; set; }
    }
}
