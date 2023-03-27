using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(ShowIfEnumAttribute))]
    public class ConditionalEnumDrawer : ConditionalBaseDrawer<ShowIfEnumAttribute>
    {
        protected override string GetPropertyName()
        {
            return GetAttribute().EnumName;
        }

        protected override bool CanHidden(SerializedProperty boolProperty)
        {
            return boolProperty.enumValueIndex != GetAttribute().ComparableEnumValue;
        }
    }
}