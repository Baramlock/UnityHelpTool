using System;

namespace HelpTool.RunTime.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ButtonAttribute : Attribute
    {
        public readonly string Name;

        public ButtonAttribute(string name = null) => Name = name;
    }
}