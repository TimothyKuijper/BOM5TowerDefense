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
    [SerializeField] private GameObject insufficientFundsMessage;
    [SerializeField] private Wallet wallet;
    public void SelectTowerS()
    {
        if (wallet.money >= 50)
        {
            selectedTower = Instantiate(towerS);
            towerSelected = true;
            wallet.money -= 50;
        }
        else
        {
            StartCoroutine(InsufficientFunds());
        }
    }

    public void SelectTowerL()
    {
        if (wallet.money >= 150)
        {
            selectedTower = Instantiate(towerL);
            towerSelected = true;
            wallet.money -= 150;

        }
        else
        {
            StartCoroutine(InsufficientFunds());
        }
    }

    IEnumerator InsufficientFunds()
    {
        insufficientFundsMessage.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        insufficientFundsMessage.SetActive(false);
    }
}
