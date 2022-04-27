using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform _origin;
    [SerializeField] private FloatVariable _fireRate;
    [SerializeField] private GameObject _laserPrefab;

    

    private float _laserTimer;
    
    private void Start() {
        _laserTimer = _fireRate.Value;
    }

    private void Update() {
        if (_laserTimer > 0) {
            _laserTimer -= Time.deltaTime;
        }
        
        if (Input.GetMouseButton(0) && _laserTimer <= 0) {
            Shoot();
            _laserTimer = _fireRate.Value;
        }
    }

    private void Shoot() {
        GameObject laser = Instantiate(_laserPrefab, _origin.position, _origin.rotation);
        laser.GetComponent<Rigidbody2D>().AddForce(laser.transform.up * 10);
    }
    
}
