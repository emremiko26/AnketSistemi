//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anketör_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Secenekler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Secenekler()
        {
            this.Cevap = new HashSet<Cevap>();
        }
    
        public int SecenekID { get; set; }
        public Nullable<int> SoruID { get; set; }
        public string SecenekMetni { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cevap> Cevap { get; set; }
        public virtual Sorular Sorular { get; set; }
    }
}
