using System;
using System.Collections.Generic;

namespace AlternatiflerCore.Models
{
    public partial class Tblresimler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Resimurl { get; set; }
        public string Resimtur { get; set; }
        public string UrunUuid { get; set; }
        public int? Indirilmedurumu { get; set; }
    }
}
