using System.Linq;
using System.Reflection;
using HelpTool.RunTime.CustomAttribute;
using UnityEditor;
using UnityEngine;

namespace HelpTool.Editor.CustomAttributeDrawer
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Object), true)]
    public class HelpToolEditor : UnityEditor.Editor
    {
        private MethodInfo[] _buttonMethods;

        private void OnEnable()
        {
            _buttonMethods = ReflectionUtility
                .GetMethods(target, x => x.GetCustomAttributes<ButtonAttribute>(true).FirstOrDefault() != null)
                .ToArray();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            foreach (MethodInfo buttonMethod in _buttonMethods)
                DrawButton(buttonMethod);
        }

        private void DrawButton(MethodInfo buttonMethod)
        {
            string buttonName = buttonMethod.GetCustomAttributes<ButtonAttribute>(true).First().Name ?? buttonMethod.Name;
            if (GUILayout.Button(buttonName))
                buttonMethod.Invoke(target, GetDefaultParams(buttonMethod));
        }

        private static object[] GetDefaultParams(MethodBase buttonMethod) =>
            buttonMethod.GetParameters().Select(p => p.DefaultValue).ToArray();
    }
}