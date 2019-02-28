using System;
namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : AttributeBase
    {
        public TableAttribute(string tableName)
        {
            Name = tableName;
        }
        public string Name { get; set; }
    }
}
