namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class HideIfAttribute : EnableIfAttribute
    {
        public HideIfAttribute(string boolName) : base(boolName)
        {
        }
    }
}