using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacer : MonoBehaviour
{
    [SerializeField] TowerSelector towerSelector;
    [SerializeField] MaxTowers maxTowers;
    void Update()
    {
        if (towerSelector.towerSelected && Input.GetAxisRaw("Fire1") >= 0.1f)
        {
            maxTowers.towersPlaced++;
            towerSelector.towerSelected = false;

        }
    }

}
