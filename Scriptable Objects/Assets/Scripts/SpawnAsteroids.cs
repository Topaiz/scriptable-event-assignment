using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private float _maxSpawnTimer;
    private float _curSpawnTimer;
    
    
    void Start() {
        _curSpawnTimer = _maxSpawnTimer;
    }

    void Update() {
        if (_curSpawnTimer >= 0) 
            _curSpawnTimer -= Time.deltaTime;
        
        else 
            Spawn();
        
    }

    void Spawn() {
        Instantiate(_asteroidPrefab, _spawnPoints[Random.Range(0, (_spawnPoints.Count - 1))].position, Quaternion.identity);
        _curSpawnTimer = _maxSpawnTimer;
    }
}
