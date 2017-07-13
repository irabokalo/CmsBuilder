using System;
using System.Collections.Generic;

namespace DomainLogic
{
    public class Element
    {
        public int ElementId { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Link> RelatedTo { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
