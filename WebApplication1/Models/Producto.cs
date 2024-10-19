namespace WebApplication1.Models.Producto
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public double PrecioFinal { get; set; }
        public string Descripcion { get; set; }

        public abstract void CalcularPrecioFinal();
    }
}
