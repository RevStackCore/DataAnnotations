using System;

namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PostCreateTableAttribute : AttributeBase
    {
        public string Sql { get; set; }

        public PostCreateTableAttribute(string sql)
        {
            Sql = sql;
        }
    }
}