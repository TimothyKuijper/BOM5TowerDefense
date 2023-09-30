using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelector : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    [SerializeField] public bool towerSelected = false;
    [SerializeField] public GameObject selectedTower;


    public void SelectTower()
    {
        selectedTower = Instantiate(tower);
        towerSelected = true;
    }
}
