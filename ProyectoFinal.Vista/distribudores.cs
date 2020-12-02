using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class distribudores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public distribudores()
        {
            this.juegos = new HashSet<juegos>();
        }

        public int distribuidor_id { get; set; }
        public System.DateTime distribuidor_fecha_fundacion { get; set; }
        public string distribuidor_razonsocial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<juegos> juegos { get; set; }
    }
}