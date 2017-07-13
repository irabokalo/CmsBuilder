using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLogic
{
    public class Link
    {
        public int FromId { get; set; }
        public int ToId { get; set; }

        public virtual Element ElementFrom { get; set; }
        public virtual Element ElementTo { get; set; }
    }
}
