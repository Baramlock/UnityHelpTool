namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class DisableIfAttribute : EnableIfAttribute
    {
        public DisableIfAttribute(string boolName) : base(boolName)
        {
        }
    }
}