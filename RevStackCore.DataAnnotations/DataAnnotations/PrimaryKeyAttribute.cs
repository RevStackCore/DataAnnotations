using System;

namespace RevStackCore.DataAnnotations
{
    /// <summary>
    /// Primary key attribute.
    /// use to indicate that property is part of the pk
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : AttributeBase
    {
        public PrimaryKeyAttribute(bool explicitKey=false)
        {
            ExplicitKey = explicitKey;
        }
        public bool ExplicitKey { get; set; }
    }
}