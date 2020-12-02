using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class copias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public copias()
        {
            this.lineasventa = new HashSet<lineasventa>();
        }

        public int copias_id { get; set; }
        public int juego_id { get; set; }

        public virtual juegos juegos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineasventa> lineasventa { get; set; }
    }
}