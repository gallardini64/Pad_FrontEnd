namespace ProyectoFinal.Vista
{
    public partial class existencias
    {
        public int existencia_id { get; set; }
        public decimal existencia_cantidad { get; set; }
        public decimal existencia_precio { get; set; }
        public int juego_id { get; set; }

        public virtual juegos juegos { get; set; }
    }
}