using UnityEngine;

namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class EnableIfAttribute : PropertyAttribute
    {
        public readonly string BoolName;

        public EnableIfAttribute(string boolName)
        {
            BoolName = boolName;
        }
    }
}