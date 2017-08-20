using System;
using System.Collections.Generic;

namespace Herhaling1.Entities
{
    public partial class StudentenCursussen
    {
        public int Studnr { get; set; }
        public int Cursusnr { get; set; }

        public virtual Cursussen CursusnrNavigation { get; set; }
        public virtual Studenten StudnrNavigation { get; set; }
    }
}
