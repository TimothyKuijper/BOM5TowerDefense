using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    void Update()
    {
        if (enemyHealth.Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
