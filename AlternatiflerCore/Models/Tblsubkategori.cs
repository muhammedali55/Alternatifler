using System;
using System.Collections.Generic;

namespace AlternatiflerCore.Models
{
    public partial class Tblsubkategori
    {
        public int Id { get; set; }
        public int? Parentid { get; set; }
        public string Ad { get; set; }
    }
}
