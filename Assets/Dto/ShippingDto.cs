
namespace Assets.Dto
{
    public class ShippingDto
    {
        public string NoRegistro { get; set; }
        public string NumDocumento { get; set; }
        public bool Confirmado { get; set; }
        public string CodigoAgente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodigoMunicipo { get; set; }
        public string Zona { get; set; }
        public string Colonia { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string FechaEntrega { get; set; }
        public int TotalPeso { get; set; }
        public int TotalVolumen { get; set; }
        public string CodigoRutaDespacho { get; set; }
        public string Especialidad { get; set; }
        public string CodigoCentroDistribucion { get; set; }
        public string Fecha { get; set; }
        public int? Bulto { get; set; }
        public string NombreCanalDistribucion { get; set; }
        public string Notas { get; set; }
    }
}
