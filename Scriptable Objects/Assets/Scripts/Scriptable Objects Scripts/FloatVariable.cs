using UnityEngine;

[CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Float Variable")]
public class FloatVariable : ScriptableObject {
    [SerializeField] private float _value;

    public float Value => _value;
}
