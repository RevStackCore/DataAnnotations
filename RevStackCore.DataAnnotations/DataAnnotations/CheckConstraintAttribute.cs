using System;

namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckConstraintAttribute : AttributeBase
    {
        public string Constraint { get; }

        public CheckConstraintAttribute(string constraint)
        {
            this.Constraint = constraint;
        }
    }
}