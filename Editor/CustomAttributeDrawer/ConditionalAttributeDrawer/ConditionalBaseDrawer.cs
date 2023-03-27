using System;
using UnityEditor;
using UnityEngine;

namespace HelpTool.Editor.CustomAttributeDrawer.ConditionalAttributeDrawer
{
    public abstract class ConditionalBaseDrawer<TProperty> : PropertyDrawer where TProperty : PropertyAttribute
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty boolProperty = FindProperty(property);
            bool isHidden = CanHidden(boolProperty);
            if (!isHidden)
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty boolProperty = FindProperty(property);
            return CanHidden(boolProperty) == false ? EditorGUI.GetPropertyHeight(property, label) : 0f;
        }

        protected virtual bool CanHidden(SerializedProperty boolProperty)
        {
            return boolProperty.boolValue;
        }

        protected TProperty GetAttribute()
        {
            return (TProperty) attribute;
        }

        protected abstract string GetPropertyName();

        private SerializedProperty FindProperty(SerializedProperty property)
        {
            SerializedProperty serializedProperty = property.serializedObject.FindProperty(GetPropertyName());

            if (serializedProperty == null)
            {
                throw new Exception("Bool property not found!");
            }

            return serializedProperty;
        }
    }
}