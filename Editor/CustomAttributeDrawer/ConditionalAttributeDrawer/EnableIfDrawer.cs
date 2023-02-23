using HelpTool.RunTime.CustomAttribute.Conditional;
using UnityEditor;
using UnityEngine;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    [CustomPropertyDrawer(typeof(EnableIfAttribute))]
    public class EnableIfDrawer : PropertyDrawer
    {
        private SerializedProperty _boolProperty;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            _boolProperty = property.serializedObject.FindProperty(((EnableIfAttribute) attribute).BoolName);
            if (_boolProperty == null)
            {
                Debug.LogError("Bool property not found!");
                return;
            }

            bool isEnabled = _boolProperty.boolValue;

            if (isEnabled)
                EditorGUI.PropertyField(position, property, label, true);
            else
            {
                GUI.enabled = false;
                EditorGUI.PropertyField(position, property, label, true);
                GUI.enabled = true;
            }
        }
    }
    
}