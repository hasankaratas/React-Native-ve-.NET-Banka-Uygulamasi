//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutunamayanlar.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class hesap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hesap()
        {
            this.havale_virman = new HashSet<havale_virman>();
            this.havale_virman1 = new HashSet<havale_virman>();
        }
    
        public string hesapNo { get; set; }
        public Nullable<long> musteriNo { get; set; }
        public Nullable<decimal> bakiye { get; set; }
        public Nullable<bool> aktiflikDurumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<havale_virman> havale_virman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<havale_virman> havale_virman1 { get; set; }
        public virtual kullanici kullanici { get; set; }
    }
}
