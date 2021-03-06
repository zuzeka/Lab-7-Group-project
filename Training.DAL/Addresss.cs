//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Training.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Addresss
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Addresss()
        {
            this.AddressDetail = new HashSet<AddressDetail>();
        }
    
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CityID { get; set; }
        public int ProvinceID { get; set; }
        public int AddressTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressDetail> AddressDetail { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual Province Province { get; set; }
    }
}
