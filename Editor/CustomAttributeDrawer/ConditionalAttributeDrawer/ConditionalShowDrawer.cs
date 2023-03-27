using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ConditionalShowDrawer : ConditionalBaseDrawer<ShowIfAttribute>
    {
        protected override string GetPropertyName()
        {
            return GetAttribute().BoolName;
        }
    }
}