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
    
    public partial class City
    {
        public int CityID { get; set; }
        public string CityDescription { get; set; }
        public Nullable<int> ProvinceID { get; set; }
    
        public virtual Province Province { get; set; }
    }
}
