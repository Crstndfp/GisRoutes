using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblImgDocumentoDig
    {
        public string IdDocumento { get; set; }
        public int IdxArch { get; set; }
        public byte[] Archivo { get; set; }
    }
}
