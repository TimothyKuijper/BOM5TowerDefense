using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMoneyOnKill : MonoBehaviour
{
    [SerializeField] GameObject manager;
    [SerializeField] Wallet wallet;
    [SerializeField] int reward;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        wallet = manager.GetComponent<Wallet>();
    }

    public void GiveMoney()
    { 
        wallet.money += reward;
    }
}
