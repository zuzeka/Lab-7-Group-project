//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Training.Training.DA.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delegate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delegate()
        {
            this.Registration = new HashSet<Registration>();
        }
    
        public int DelegateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public int DietaryID { get; set; }
        public int AddressDetailID { get; set; }
    
        public virtual AddressDetail AddressDetail { get; set; }
        public virtual Dietary Dietary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registration { get; set; }
    }
}