namespace ProyectoFinal.Vista
{
    public partial class lineasventa
    {
        public int lineaventa_id { get; set; }
        public decimal subtotal { get; set; }
        public int copias_id { get; set; }
        public int ventas_id { get; set; }
        public int cantidad { get; set; }

        public virtual copias copias { get; set; }
        public virtual ventas ventas { get; set; }
    }
}