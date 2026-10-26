using UnityEditor;
using UnityEngine.Rendering;

namespace IXD.AR.Editor
{
    // Menu: IXD > Apply Android AR Settings
    public static class AndroidBuildDefaults
    {
        [MenuItem("IXD/Apply Android AR Settings")]
        public static void Apply()
        {
            PlayerSettings.SetScriptingBackend(UnityEditor.Build.NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
            PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
            PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
            PlayerSettings.SetGraphicsAPIs(BuildTarget.Android, new[] { GraphicsDeviceType.OpenGLES3 });
            PlayerSettings.SetApplicationIdentifier(UnityEditor.Build.NamedBuildTarget.Android, "com.ixd.arstarter");
            UnityEngine.Debug.Log("IXD: Android AR settings applied.");
        }
    }
}
