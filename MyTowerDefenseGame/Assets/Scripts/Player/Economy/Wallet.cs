using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int money;
    void Start()
    {
        money = 50;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            money += 200;
        }  
    }
}
