
namespace TestPackage
{
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(TestPackage))]
    public class TestPackageEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if(GUILayout.Button("Debug Message"))
                ((TestPackage)target).DebugMessage();
        }
    }
}