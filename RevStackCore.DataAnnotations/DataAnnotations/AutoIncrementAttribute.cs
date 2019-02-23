using System;

namespace RevStackCore.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class AutoIncrementAttribute : AttributeBase
    {
    }
}