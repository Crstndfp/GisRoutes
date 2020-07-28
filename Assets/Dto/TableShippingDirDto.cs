
namespace Assets.Dto
{
    public class TableShippingDirDto
    {
        public string IdEnvio { get; set; }
        public string CodPais { get; set; }
        public byte CodDepartamento { get; set; }
        public byte CodMunicipio { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double GeoRefX { get; set; }
        public double GeoRefY { get; set; }
        public string CodUbicacion { get; set; }
    }
}
