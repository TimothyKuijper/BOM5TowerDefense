using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFollowMouse : MonoBehaviour
{
    [SerializeField] TowerSelector towerSelector;
    [SerializeField] MouseFollower mouseFollower;
    void Update()
    {
        if (towerSelector.towerSelected == true)
        {
            towerSelector.selectedTower.transform.position = new Vector3(mouseFollower.mousePos.x, mouseFollower.mousePos.y);
        }
    }
}
