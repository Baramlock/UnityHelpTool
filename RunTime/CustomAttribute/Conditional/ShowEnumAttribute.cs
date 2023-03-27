using UnityEngine;

namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class ShowIfEnumAttribute : PropertyAttribute
    {
        public readonly string EnumName;
        public readonly int ComparableEnumValue;

        public ShowIfEnumAttribute(string enumName, int comparableEnumValue)
        {
            ComparableEnumValue = comparableEnumValue;
            EnumName = enumName;
        }
    }
}