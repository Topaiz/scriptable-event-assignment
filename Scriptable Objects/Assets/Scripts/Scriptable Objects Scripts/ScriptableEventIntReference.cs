using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEventIntReference", menuName = "ScriptableObjects/ScriptableEvent-IntReference")]
public class ScriptableEventIntReference : ScriptableEvent<IntReference> {
    public void Raise(int newValue) {
        Raise(new IntReference(newValue));
    }

}