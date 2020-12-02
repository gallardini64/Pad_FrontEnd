using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class generos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public generos()
        {
            this.juegos = new HashSet<juegos>();
        }

        public int genero_id { get; set; }
        public string genero_descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<juegos> juegos { get; set; }
    }
}