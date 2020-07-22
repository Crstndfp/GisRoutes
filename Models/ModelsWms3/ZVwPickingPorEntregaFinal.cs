using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwPickingPorEntregaFinal
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public string Tienda { get; set; }
        public string Pedido { get; set; }
        public string Entrega { get; set; }
        public int? PosEntrega { get; set; }
        public int? UnidadesAPickear { get; set; }
        public int? UnidadesPickeadas { get; set; }
        public int Pickeada { get; set; }
        public string Sku { get; set; }
        public string NombreSku { get; set; }
        public string Departamento { get; set; }
        public int Linea { get; set; }
        public int PickingCompleto { get; set; }
        public int PickingParcial { get; set; }
        public int PickingCero { get; set; }
        public int SinPicking { get; set; }
    }
}
