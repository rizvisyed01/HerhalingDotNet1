using System;
using System.Collections.Generic;

namespace Herhaling1.Entities
{
    public partial class Boete
    {
        public int Studnr { get; set; }
        public int? Boet { get; set; }

        public virtual Studenten StudnrNavigation { get; set; }
    }
}
