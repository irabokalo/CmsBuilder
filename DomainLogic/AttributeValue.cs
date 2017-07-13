using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLogic
{
    public class AttributeValue
    {
        public int AttributeValueId { get; set; }
        public  string Value { get; set; }
        public virtual Attribute AttributeId { get; set; }
    }
}
