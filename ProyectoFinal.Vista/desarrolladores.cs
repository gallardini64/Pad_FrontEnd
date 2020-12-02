using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class desarrolladores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public desarrolladores()
        {
            this.juegos = new HashSet<juegos>();
        }

        public int desarrollador_id { get; set; }
        public System.DateTime desarrollador_fecha_fundacion { get; set; }
        public string desarrollador_razonsocial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<juegos> juegos { get; set; }
    }
}