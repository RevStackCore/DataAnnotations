﻿using System;

namespace RevStackCore.DataAnnotations
{
    /// <summary>
    /// Used to indicate that property is a row version incremented automatically by the database
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RowVersionAttribute : AttributeBase
    {
    }
}
