using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private PlayerHealth PHealth;
    void Start()
    {
        
    }

    void Update()
    {
        if (PHealth.health <= 0)
        {

        }
    }
}
