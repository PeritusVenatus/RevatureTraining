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
    
    public partial class Professor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professor()
        {
            this.Courses = new HashSet<Cours>();
        }
    
        public int ProfessorId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual ProfessorSchedule ProfessorSchedule { get; set; }
    }
}