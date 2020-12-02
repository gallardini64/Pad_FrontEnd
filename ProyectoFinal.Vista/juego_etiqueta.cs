using System;

namespace ProyectoFinal.Vista
{
    public partial class juego_etiqueta
    {
        public int juego_id { get; set; }
        public int etiqueta_id { get; set; }
        public Nullable<int> juego_etiqueta_id { get; set; }

        public virtual etiquetas etiquetas { get; set; }
        public virtual juegos juegos { get; set; }
    }
}