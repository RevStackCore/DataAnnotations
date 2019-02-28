using System;
using System.Data;

namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SqlTypeAttribute : AttributeBase
    {
        public SqlTypeAttribute(SqlDbType type)
        {
            Type = type;
        }

        public SqlTypeAttribute(SqlDbType type, int size)
        {
            Type = type;
            Size = size;
        }

        public SqlTypeAttribute(SqlDbType type, int size, int precision)
        {
            Type = type;
            Size = size;
            Precision = precision;
        }

        public SqlDbType Type { get; set; }
        public int Size { get; set; }
        public int Precision { get; set; }

    }
}
