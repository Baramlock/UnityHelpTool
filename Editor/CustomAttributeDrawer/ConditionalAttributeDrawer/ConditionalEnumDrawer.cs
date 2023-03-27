using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;
using UnityEngine;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(ShowIfEnumAttribute))]
    public class ConditionalEnumDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty boolProperty = FindProperty(property);
            if (boolProperty == null)
            {
                Debug.LogError("Bool property not found!");
                return;
            }

            bool isHidden = CanHidden(boolProperty);
            if (!isHidden)
                EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty boolProperty = FindProperty(property);
            if (boolProperty == null || CanHidden(boolProperty) == false)
            {
                return EditorGUI.GetPropertyHeight(property, label);
            }

            return 0f;
        }

        private SerializedProperty FindProperty(SerializedProperty property)
        {
            return property.serializedObject.FindProperty(((ShowIfEnumAttribute) attribute).EnumName);
        }

        private bool CanHidden(SerializedProperty boolProperty)
        {
            return boolProperty.enumValueIndex != ((ShowIfEnumAttribute) attribute).ComparableEnumValue;
        }
    }
}