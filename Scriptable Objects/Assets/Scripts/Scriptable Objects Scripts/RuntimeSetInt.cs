using UnityEngine;

namespace Scriptable_Objects_Scripts {
    [CreateAssetMenu(fileName = "RuntimeSetInt", menuName = "ScriptableObjects/RuntimeSet-Int")]
    public class RuntimeSetInt : RuntimeSet<IntReference> {
        public void Add(int newValue) {
            Add(new IntReference(newValue));
        }
    }
}