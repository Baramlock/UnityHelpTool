using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace HelpTool.Editor
{
    public static class ProjectInitializerWebGL
    {
        [MenuItem("Tool/Installers/Web", isValidateFunction: true, priority = 0)]
        public static bool IsWebGL() => EditorUserBuildSettings.activeBuildTarget == BuildTarget.WebGL;

        [MenuItem("Tool/Installers/Web", priority = 1)]
        public static void InitProject()
        {
            SetWenGLSettings();
            SetDefaultGraphics();
        }

        private static void SetWenGLSettings()
        {
            PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Brotli;
            PlayerSettings.WebGL.nameFilesAsHashes = true;
            PlayerSettings.WebGL.dataCaching = false;
            PlayerSettings.WebGL.decompressionFallback = true;
            PlayerSettings.runInBackground = true;
            EditorUserBuildSettings.webGLBuildSubtarget = WebGLTextureSubtarget.ASTC;
        }

        private static void SetDefaultGraphics()
        {
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.WebGL, ScriptingImplementation.IL2CPP);
            PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64 | AndroidArchitecture.ARMv7;
            PlayerSettings.colorSpace = ColorSpace.Gamma;
            PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.WebGL, false);
            PlayerSettings.SetGraphicsAPIs(BuildTarget.WebGL,
                new[] {GraphicsDeviceType.OpenGLES3, GraphicsDeviceType.OpenGLES2});
        }
    }
}