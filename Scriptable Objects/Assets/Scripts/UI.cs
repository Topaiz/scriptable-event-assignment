using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;


public class UI : MonoBehaviour
{
    [SerializeField] private IntVariable _healthVar;
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;


    private void OnEnable() {
        _onHealthChangedEvent.Register(OnHealthChanged);
    }

    private void OnDisable() {
        _onHealthChangedEvent.Unregister(OnHealthChanged);
    }

    private void Start() {
        SetHealthText($"Health: {_healthVar.Value}");
    }

    public void OnHealthChanged(IntReference newValue) {
        Debug.Log("Health Changed!");
        SetHealthText($"Health: {newValue.GetValue()}");
    }

    private void SetHealthText(string text) {
        _healthText.text = text;
    }
}
