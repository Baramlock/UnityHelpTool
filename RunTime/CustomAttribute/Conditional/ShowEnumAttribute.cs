using UnityEngine;

namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class ShowEnumAttribute : PropertyAttribute
    {
        public readonly string EnumName;
        public readonly int EnumValue;

        public ShowEnumAttribute(string enumName, int enumValue)
        {
            EnumValue = enumValue;
            EnumName = enumName;
        }
    }
}