using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacer : MonoBehaviour
{
    [SerializeField] TowerSelector towerSelector;
    void Start()
    {
        
    }

    void Update()
    {
        if (towerSelector.towerSelected == true && Input.GetAxisRaw("Fire1") >= 0.1f)
        {
            towerSelector.towerSelected = false;
        }
    }
}
