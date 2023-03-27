using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(HideIfAttribute))]
    public class ConditionalHideDrawer : ConditionalBaseDrawer<HideIfAttribute>
    {
        protected override string GetPropertyName()
        {
            return GetAttribute().BoolName;
        }

        protected override bool CanHidden(SerializedProperty boolProperty)
        {
            return base.CanHidden(boolProperty) == false;
        }
    }
}