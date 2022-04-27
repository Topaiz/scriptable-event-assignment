using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private ScriptableEventString _onLaserHitAsteroidEvent;
    [SerializeField] private ScriptableEventIntReference _onLaserHitAsteroidIntReferenceEvent;
    [SerializeField] private ScriptableEventInt _onLaserHitAsteroidIntEvent;
    [SerializeField] private ScriptableEventGameObject _onLaserHitGameObject;
    
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Asteroid")) {
    
            var asteroid = other.gameObject.GetComponent<Asteroid>();
            var id = asteroid.GetInstanceID();
            //_onLaserHitAsteroidIntReferenceEvent.Raise(id);
            //_onLaserHitAsteroidIntEvent.Raise(id);
            asteroid.DestroyMe();
            
            //_onLaserHitGameObject.Raise(other.gameObject);
        }
    }
}
