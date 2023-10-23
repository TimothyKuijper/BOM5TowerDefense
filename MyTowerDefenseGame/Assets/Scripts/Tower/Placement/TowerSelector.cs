using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelector : MonoBehaviour
{
    [SerializeField] private GameObject towerS;
    [SerializeField] private GameObject towerL;
    [SerializeField] public bool towerSelected = false;
    [SerializeField] public GameObject selectedTower;
    [SerializeField] public GameObject bow;
    public void SelectTowerS()
    {
        selectedTower = Instantiate(towerS);
        towerSelected = true;
    }

    public void SelectTowerL()
    {
        selectedTower = Instantiate(towerL);
        towerSelected = true;
    }
}
