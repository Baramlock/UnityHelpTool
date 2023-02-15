using UnityEngine;

namespace HelpTool.RunTime.CustomAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Property, AllowMultiple = true)]
    public sealed class MaxAttribute : PropertyAttribute
    {
        public readonly float max;

        public MaxAttribute(float max) => this.max = max;
    }
}