﻿using System;

namespace RevStackCore.DataAnnotations
{
    /// <summary>
    /// Used to annotate an Entity with its DB schema
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SchemaAttribute : AttributeBase
    {
        public SchemaAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}