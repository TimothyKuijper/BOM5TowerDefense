using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaxTowers : MonoBehaviour
{
    [SerializeField] public int towersPlaced;
    [SerializeField] private TMP_Text towerAmountText;

    void Start()
    {
        towersPlaced = 0;
    }

    private void Update()
    {
        towerAmountText.text = "Placed Towers: " + towersPlaced + "/6";
    }

}
