using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMoneyOnKill : MonoBehaviour
{
    [SerializeField] EnemyHealth enemyHealth;
    [SerializeField] GameObject manager;
    [SerializeField] Wallet wallet;
    [SerializeField] int reward;


    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        wallet = manager.GetComponent<Wallet>();
    }
    void Update()
    {
        if (enemyHealth.Health <= 0)
        {
            wallet.money += reward;
        }
    }
}
