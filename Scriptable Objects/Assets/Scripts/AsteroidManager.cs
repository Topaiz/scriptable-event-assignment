using System.Collections;
using System.Collections.Generic;
using Scriptable_Objects_Scripts;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] public List<Asteroid> _asteroids = new List<Asteroid>();

    [SerializeField] private GameObject _asteroidPrefab;
    
    [SerializeField] private float _maxSpawnTimer;
    private float _curSpawnTimer;
    
    [SerializeField] private ScriptableEventInt _onLaserHitEvent;
    [SerializeField] private RuntimeSetInt _astRuntimeSet;
    [SerializeField] private RuntimeSetGameObject _astRuntimeSetGameObj;
    


    private void OnEnable() {
        //_onLaserHitEvent.Register(OnLaserHitInt);
    }

    private void OnDisable() {
        //_onLaserHitEvent.Unregister(OnLaserHitInt);
    }
    
    void Start() {
        if (FindObjectsOfType<Asteroid>() != null) {
            foreach (var asteroid in FindObjectsOfType<Asteroid>()) {
                _asteroids.Add(asteroid);
            }
        }
        
        _curSpawnTimer = _maxSpawnTimer;
    }

    void Update() {
        if (_curSpawnTimer >= 0) 
            _curSpawnTimer -= Time.deltaTime;
        
        else 
            Spawn();
        
    }

    void Spawn() {
        GameObject asteroid = Instantiate(_asteroidPrefab, _spawnPoints[Random.Range(0, (_spawnPoints.Count - 1))].position, Quaternion.identity);
        _curSpawnTimer = _maxSpawnTimer;
    }
    
    public void OnLaserHitInt(IntReference asteroidId) {
        /*if (_instanceId == asteroidId.GetValue()) {
            Destroy(gameObject);
        }
        */

        if (_astRuntimeSet.Items.Contains(asteroidId)) {
            //Destroy();
        }
    }

    public void OnLaserHitObj(GameObject asteroid) {
        if (_astRuntimeSetGameObj.Items.Contains(asteroid)) {
            Destroy(asteroid);
        }
    }
}
