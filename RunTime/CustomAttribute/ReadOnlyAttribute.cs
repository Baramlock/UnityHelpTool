using UnityEngine;

namespace HelpTool.CustomAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
    public sealed class ReadOnlyAttribute : PropertyAttribute
    {
    }
}