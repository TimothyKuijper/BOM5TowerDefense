using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(1);
        }
    }
}
