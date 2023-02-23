using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;
using UnityEngine;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ConditionalShowDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var boolProperty = property.serializedObject.FindProperty(((ShowIfAttribute) attribute).BoolName);
            if (boolProperty == null)
            {
                Debug.LogError("Bool property not found!");
                return;
            }

            bool isHidden = boolProperty.boolValue;
            if (!isHidden) EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var boolProperty = property.serializedObject.FindProperty(((ShowIfAttribute) attribute).BoolName);
            if (boolProperty == null || !boolProperty.boolValue)
            {
                return EditorGUI.GetPropertyHeight(property, label);
            }

            return 0f;
        }
    }
}