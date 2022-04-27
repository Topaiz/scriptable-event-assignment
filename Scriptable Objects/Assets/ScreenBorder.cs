using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBorder : MonoBehaviour {
    [SerializeField] private ScriptableEventVector2 _onLeaveScreenEvent;
    
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            var position = other.transform.position;
            _onLeaveScreenEvent.Raise(position);
        }
    }
}
