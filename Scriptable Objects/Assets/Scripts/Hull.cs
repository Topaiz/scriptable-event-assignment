using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull : MonoBehaviour
{
    [SerializeField] private IntVariable _health;
    [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Asteroid")) {
            _health.ApplyChange(-1);
            _onHealthChangedEvent.Raise(_health.Value);
        }
    }
}
