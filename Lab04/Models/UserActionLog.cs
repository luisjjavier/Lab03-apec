//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab04.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserActionLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public int AuditedAction { get; set; }
        public System.DateTime AuditDate { get; set; }
        public bool Status { get; set; }
    }
}
