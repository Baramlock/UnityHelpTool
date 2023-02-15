using UnityEditor;
using UnityEngine;
using ReadOnlyAttribute = HelpTool.RunTime.CustomAttribute.ReadOnlyAttribute;

namespace HelpTool.Editor.CustomAttributeDrawer
{
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public sealed class ReadOnlyAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label);
            GUI.enabled = true;
        }
    }
}