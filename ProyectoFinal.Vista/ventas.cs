using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ventas()
        {
            this.lineasventa = new HashSet<lineasventa>();
        }

        public int ventas_id { get; set; }
        public System.DateTime venta_fecha { get; set; }
        public decimal ventas_total { get; set; }
        public int usuario_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineasventa> lineasventa { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}