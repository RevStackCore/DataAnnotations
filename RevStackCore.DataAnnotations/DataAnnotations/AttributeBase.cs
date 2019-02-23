using System;
namespace RevStackCore.DataAnnotations
{
    public class AttributeBase : Attribute
    {
        public AttributeBase()
        {
            this.typeId = Guid.NewGuid();
        }

        protected readonly Guid typeId; //Hack required to give Attributes unique identity
    }
}
