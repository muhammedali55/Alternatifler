using System;
using System.Collections.Generic;

namespace AlternatiflerCore.Models
{
    public partial class Tblsubsistem
    {
        public int Id { get; set; }
        public int? Parentid { get; set; }
        public string Ad { get; set; }
        public int? Urunadedi { get; set; }
    }
}
