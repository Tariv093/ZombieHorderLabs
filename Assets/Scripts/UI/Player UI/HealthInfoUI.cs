using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HealthInfoUI : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;

    private HealthComponent PlayerHealthComponent;
    private void OnEnable()
    {
        PlayerEvents.OnHealthInitialized += OnHealthInitialized;
    }

    private void OnHealthInitialized(HealthComponent healthComponent)
    {
        PlayerHealthComponent = healthComponent;
    }

    private void OnDisable()
    {
        PlayerEvents.OnHealthInitialized -= OnHealthInitialized;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = PlayerHealthComponent.GetHealth.ToString();
    }
}
