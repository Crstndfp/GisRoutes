﻿using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblContactoCliente
    {
        public string CodCliente { get; set; }
        public int Idx { get; set; }
        public int CodTipoIdent { get; set; }
        public string SerieId { get; set; }
        public string NumeroId { get; set; }
        public int CodTipoCont { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string TelOficina { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
