using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private PlayerHealth playerHealth;
    void Start()
    {
        
    }

    void Update()
    {
        slider.value = playerHealth.health;
    }
}
