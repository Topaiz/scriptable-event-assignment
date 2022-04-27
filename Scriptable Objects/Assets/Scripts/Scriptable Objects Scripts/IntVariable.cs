using UnityEngine;

[CreateAssetMenu(fileName = "new IntVariable", menuName = "ScriptableObjects/IntVariable")]
public class IntVariable : ScriptableObject {
    [SerializeField] private int _value;

    private int _curValue;

    public int Value => _curValue;

    private void OnEnable() {
        _curValue = _value;
    }
    public void ApplyChange(int change) {
        _curValue += change;
    }
}
