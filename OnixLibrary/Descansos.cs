//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnixLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Descansos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Descansos()
        {
            this.EjercicioRutina = new HashSet<EjercicioRutina>();
        }
    
        public int IdDescanso { get; set; }
        public string TiempoDescanso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EjercicioRutina> EjercicioRutina { get; set; }
    }
}
