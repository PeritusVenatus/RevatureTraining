//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationApp.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Gender { get; set; }
        public string Major { get; set; }
        public Nullable<int> CreditHours { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public bool Active { get; set; }
    
        public virtual StudentSchedule StudentSchedule { get; set; }
    }
}