using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ProyectoFinal.Vista
{
    public partial class juegos
    {
        private DateTime _fecha;  

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public juegos()
        {
            this.copias = new HashSet<copias>();
            this.existencias = new HashSet<existencias>();
            this.juego_etiqueta = new HashSet<juego_etiqueta>();
        }
        
        public int juego_id { get; set; }
        
        public string titulo { get; set; }
        public string imagen { get; set; }
        public System.DateTime fecha_lanzamiento
        {
            get => _fecha;
            set => _fecha = value.Date;
        }
        public int genero_id { get; set; }

        public string genero_nombre { get; set; }
        public int desarrollador_id { get; set; }

        public string dessarrollador_nombre { get; set; }
        public int distribuidor_id { get; set; }

        public string distribudor_nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<copias> copias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<existencias> existencias { get; set; }
        public virtual desarrolladores desarrolladores { get; set; }
        public virtual distribudores distribudores { get; set; }
        public virtual generos generos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<juego_etiqueta> juego_etiqueta { get; set; }
    }
}