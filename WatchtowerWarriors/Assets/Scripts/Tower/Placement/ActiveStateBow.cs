using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveStateBow : MonoBehaviour
{
    [SerializeField] private Shoot shoot;
    private bool ShootingStarted = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ShootingStarted == false)
        {
            shoot.StartShooting();
            ShootingStarted = true;
        }
    }
}
