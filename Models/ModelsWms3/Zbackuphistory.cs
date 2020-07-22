using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class Zbackuphistory
    {
        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public DateTime? BackupStartDate { get; set; }
        public DateTime? BackupFinishDate { get; set; }
        public string BackupType { get; set; }
        public decimal? BackupSize { get; set; }
        public string PhysicalDeviceName { get; set; }
        public string BackupsetName { get; set; }
    }
}
