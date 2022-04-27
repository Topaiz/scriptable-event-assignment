using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {
    private Camera _mainCamera;
    private Rigidbody2D _rb;

    [SerializeField] private FloatVariable _thrust;
    [SerializeField] private FloatVariable _angularDrag;
    [SerializeField] private ParticleSystem _thrusterParticles;
    private 
    
    void Start() {
        _mainCamera = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        Inputs();
    }

    void Inputs() {
        
        //Look at Mouse
        Vector3 mousePos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        _rb.MoveRotation(Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90);
        
        //Right Click   
        if (Input.GetMouseButton(1)) {
            _rb.drag = 0;
            Thrust();
        }

        else {
            _rb.drag = 2;
            ParticleSystem.EmissionModule em = _thrusterParticles.emission;
            em.enabled = false;
        }
        
    }

    void Thrust() {
        _rb.AddForce(transform.up * _thrust.Value);
        ParticleSystem.EmissionModule em = _thrusterParticles.emission;
        em.enabled = true;
    }
}
