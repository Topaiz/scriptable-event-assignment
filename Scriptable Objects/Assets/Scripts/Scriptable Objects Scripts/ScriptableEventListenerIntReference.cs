using System;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListenerIntReference : ScriptableEventListener<IntReference, ScriptableEventIntReference, UnityEvent<IntReference>> {
    
}

[Serializable]
public class UnityEventInt : UnityEvent<int> {
    
}

[Serializable]
public class UnityEventGuid : UnityEvent<Guid> {
    
}