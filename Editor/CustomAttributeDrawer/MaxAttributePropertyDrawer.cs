using UnityEditor;
using UnityEngine;
using MaxAttribute = HelpTool.RunTime.CustomAttribute.MaxAttribute;

namespace HelpTool.Editor.CustomAttributeDrawer
{
    [CustomPropertyDrawer(typeof(MaxAttribute))]
    public sealed class MaxAttributePropertyDrawer : PropertyDrawer
    {
        private static readonly string InvalidTypeMessage = L10n.Tr("Use Min with float, int or Vector.");
        private MaxAttribute maxAttribute => attribute as MaxAttribute;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField(position, property, label);
            if (!EditorGUI.EndChangeCheck())
                return;
            if (property.propertyType == SerializedPropertyType.Float)
            {
                property.floatValue = Mathf.Min(maxAttribute.max, property.floatValue);
            }
            else if (property.propertyType == SerializedPropertyType.Integer)
            {
                property.intValue = Mathf.Min((int) maxAttribute.max, property.intValue);
            }
            else if (property.propertyType == SerializedPropertyType.Vector2)
            {
                Vector2 value = property.vector2Value;
                property.vector2Value = new Vector2(Mathf.Min(maxAttribute.max, value.x),
                    Mathf.Min(maxAttribute.max, value.y));
            }
            else if (property.propertyType == SerializedPropertyType.Vector2Int)
            {
                Vector2Int value = property.vector2IntValue;
                property.vector2IntValue = new Vector2Int(Mathf.Min((int) maxAttribute.max, value.x),
                    Mathf.Min((int) maxAttribute.max, value.y));
            }
            else if (property.propertyType == SerializedPropertyType.Vector3)
            {
                Vector3 value = property.vector3Value;
                property.vector3Value = new Vector3(Mathf.Min(maxAttribute.max, value.x),
                    Mathf.Min(maxAttribute.max, value.y), Mathf.Min(maxAttribute.max, value.z));
            }
            else if (property.propertyType == SerializedPropertyType.Vector3Int)
            {
                Vector3Int value = property.vector3IntValue;
                property.vector3IntValue = new Vector3Int(Mathf.Min((int) maxAttribute.max, value.x),
                    Mathf.Min((int) maxAttribute.max, value.y), Mathf.Min((int) maxAttribute.max, value.z));
            }
            else if (property.propertyType == SerializedPropertyType.Vector4)
            {
                Vector4 value = property.vector4Value;
                property.vector4Value = new Vector4(Mathf.Min(maxAttribute.max, value.x),
                    Mathf.Min(maxAttribute.max, value.y), Mathf.Min(maxAttribute.max, value.z),
                    Mathf.Min(maxAttribute.max, value.w));
            }
            else
            {
                EditorGUI.LabelField(position, label.text, InvalidTypeMessage);
            }
        }
    }
}