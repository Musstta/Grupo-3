//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grupo_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int RegistrationId { get; set; }
        public int ConferenceId { get; set; }
        public string AttendeeId { get; set; }
        public System.DateTime RegistrationDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Conference Conference { get; set; }
    }
}
