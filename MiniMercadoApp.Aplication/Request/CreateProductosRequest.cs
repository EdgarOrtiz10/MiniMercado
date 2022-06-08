namespace MiniMercadoApp.Application.Requests
{
    public class CreateProductosRequest
    {
        public int IdProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public int Precio { get; set; }

        public int IdCategoria { get; set; }

        public int IdProveedor { get; set; }

    }
}
