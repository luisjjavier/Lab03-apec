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
    
    public partial class WebHookClient
    {
        public int Id { get; set; }
        public string ConfigurationName { get; set; }
        public int Methodtype { get; set; }
        public float Timeout { get; set; }
        public string ClientServer { get; set; }
        public string ClientResource { get; set; }
        public int SubscriptionType { get; set; }
        public int EventType { get; set; }
    }
}
