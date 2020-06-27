using System;
namespace RevStackCore.DataAnnotations.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ColumnAttribute : AttributeBase
    {
        public ColumnAttribute(string columnName)
        {
            Name = columnName;
        }
        public string Name { get; set; }
    }
}
