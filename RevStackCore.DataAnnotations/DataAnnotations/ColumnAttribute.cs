using System;
namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : AttributeBase
    {
        public ColumnAttribute(string columnName)
        {
            Name = columnName;
        }
        public string Name { get; set; }
    }
}
