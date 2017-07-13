using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLogic
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public ICollection<AttributeValue> Values { get; set; }
    }
}
