using UnityEngine.Events;
using System;

public class ScriptableEventListenerString : ScriptableEventListener<string, ScriptableEventString, UnityEvent<string>> {
    
}


[Serializable]
public class UnityEventString : UnityEvent<string> {
    
}