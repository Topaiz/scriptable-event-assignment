using UnityEditor;
using UnityEngine;

namespace Scriptable_Objects_Scripts.Editor {
    
    [CustomEditor(typeof(ScriptableEventBase))]
    public class ScriptableEventEditor : UnityEditor.Editor {
        private ScriptableEventBase _target;
        
        public override void OnInspectorGUI() {
            _target = target as ScriptableEventBase;
            
            
            base.OnInspectorGUI();

            Object myTarget = target;
            if (GUILayout.Button("Debug Raise Event")) {
                _target.Raise();
            }
        }
    }
}