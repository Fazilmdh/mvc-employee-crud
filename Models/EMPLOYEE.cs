//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeMVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EMPLOYEE
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="This Field Required")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
