using System;
using System.Collections.Generic;
using System.Reflection;
using Object = UnityEngine.Object;

namespace HelpTool.Editor
{
    public static class ReflectionUtility
    {
        public static IEnumerable<MethodInfo> GetMethods(Object target, Func<MethodInfo, bool> condition)
        {
            if (target == false)
                yield break;

            var methodInfos = target.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic|  BindingFlags.DeclaredOnly);

            foreach (MethodInfo info in methodInfos)
                if (condition(info))
                    yield return info;
        }
    }
}