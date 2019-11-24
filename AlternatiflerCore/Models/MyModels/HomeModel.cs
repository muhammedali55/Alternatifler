using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlternatiflerCore.Models.MyModels
{
    public class HomeModel
    {
        public List<Tblkategoriler> kategorilist { get; set; }
        public List<Tblsubkategori> altkategorilist { get; set; }
        public List<Tblsistem> sistemlist { get; set; }
        public List<Tblsubsistem> altsistemlist { get; set; }
        public List<Tblgeciciurunbilgisi> urunlist { get; set; }
        public List<Tblgeciciurunbilgisi> alternatiflerdearananlar { get; set; }
        public List<Tblgeciciurunbilgisi> encokarananlar { get; set; }
        public Tblgeciciurunbilgisi urun { get; set; }
    }
}
