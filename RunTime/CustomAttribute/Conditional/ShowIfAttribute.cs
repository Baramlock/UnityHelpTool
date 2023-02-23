namespace HelpTool.RunTime.CustomAttribute.Conditional
{
    public class ShowIfAttribute : EnableIfAttribute
    {
        public ShowIfAttribute(string boolName) : base(boolName)
        {
        }
    }
}