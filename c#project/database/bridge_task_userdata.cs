//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace c_project.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class bridge_task_userdata
    {
        public int u_id { get; set; }
        public int t_id { get; set; }
        public Nullable<System.DateTime> collbration_date { get; set; }
    
        public virtual task task { get; set; }
        public virtual userdata userdata { get; set; }
    }
}
