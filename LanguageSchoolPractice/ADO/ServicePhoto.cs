//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LanguageSchoolPractice.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicePhoto
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public string PhotoPath { get; set; }
        public byte[] PhotoBytes { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
