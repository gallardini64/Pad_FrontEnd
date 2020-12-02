using System.Collections.Generic;

namespace ProyectoFinal.Vista
{
    public partial class etiquetas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public etiquetas()
        {
            this.juego_etiqueta = new HashSet<juego_etiqueta>();
        }

        public int etiqueta_id { get; set; }
        public string etiqueta_descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<juego_etiqueta> juego_etiqueta { get; set; }
    }
}