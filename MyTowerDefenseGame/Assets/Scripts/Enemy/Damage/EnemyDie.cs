using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    [SerializeField] private GetMoneyOnKill getMoneyOnKill;
    void Update()
    {
        if (enemyHealth.Health <= 0)
        {
            getMoneyOnKill.GiveMoney();
            Destroy(gameObject);
        }
    }
}
