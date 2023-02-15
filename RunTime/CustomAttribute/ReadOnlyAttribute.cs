using UnityEngine;

namespace HelpTool.RunTime.CustomAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
    public sealed class ReadOnlyAttribute : PropertyAttribute
    {
    }
}