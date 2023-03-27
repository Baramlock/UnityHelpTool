namespace HelpTool.RunTime.Extension
{
    public static class UnityExtension
    {
        /// <summary>
        /// Return true if object is not null
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool Exist(this object self)
        {
            return self != null;
        }

        /// <summary>
        /// Return true if object is not null
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool Exist(this UnityEngine.Object self)
        {
            return self;
        }

        /// <summary>
        /// Return true if object is null
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool NotExist(this object self)
        {
            return self == null;
        }

        /// <summary>
        /// Return true if object is null
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool NotExist(this UnityEngine.Object self)
        {
            return !self;
        }
    }
}