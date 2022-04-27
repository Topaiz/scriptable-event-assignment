using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Scriptable_Objects_Scripts;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    [SerializeField] private IntVariable _asteroidHealth;
    [SerializeField] private int _curHealth;
    [SerializeField] private RuntimeSetInt _asteroidRuntimeSet;
    [SerializeField] private RuntimeSetGameObject _astRuntimeSetGameObject;



    private Transform _target;
    private Rigidbody2D _rb;
    private int _instanceId;
    
    //Reference scriptable object (list of all managers, runtime set)
    
    void Start() {
        _instanceId = GetInstanceID();
        _target = FindObjectOfType<Engine>().transform;
        _rb = GetComponent<Rigidbody2D>();
        
        transform.up = _target.position - transform.position;
        _rb.velocity = transform.up * 5;

        _curHealth = _asteroidHealth.Value;

        var asteroidGuid = Guid.NewGuid();
        //Register scriptable object
        _asteroidRuntimeSet.Add(_instanceId);
        _astRuntimeSetGameObject.Add(gameObject);
    }
    
    private void OnBecameInvisible() {
        if (FindObjectOfType<AsteroidManager>() != null) {
            FindObjectOfType<AsteroidManager>()._asteroids.Remove(this);
        }
        Destroy(gameObject);
    }

    //Move to manager
    public void OnLaserHit(IntReference asteroidid) {
        if (asteroidid.GetValue() == _instanceId) {
            Destroy(gameObject);
        }
    }
    
    public void OnLaserHitInt(int asteroidid) {
        if (asteroidid == _instanceId) {
            Destroy(gameObject);
        }
    }

    public void DestroyMe() {
        Destroy(gameObject);
        //Raise onAsteroidDestroyed event or something
    }

}
