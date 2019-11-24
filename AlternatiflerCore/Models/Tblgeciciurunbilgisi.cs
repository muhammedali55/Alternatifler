using System;
using System.Collections.Generic;

namespace AlternatiflerCore.Models
{
    public partial class Tblgeciciurunbilgisi
    {
        public int Id { get; set; }
        public string Urlad { get; set; }
        public string Urunurl { get; set; }
        public string Ad { get; set; }
        public string Uretici { get; set; }
        public string Etiketler { get; set; }
        public string Aciklama { get; set; }
        public string Uuid { get; set; }
        public string SiteUuid { get; set; }
        public int? Islemdurumu { get; set; }
    }
}
