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
    [SerializeField] MaxTowers maxTowers;
    [SerializeField] private Wallet wallet;
    [SerializeField] private GameObject towerAmountError;

    public void SelectTowerS()
    {
        if (wallet.money >= 50 && maxTowers.towersPlaced < 6)
        {
            selectedTower = Instantiate(towerS);
            towerSelected = true;
            wallet.money -= 50;
        }
        if (maxTowers.towersPlaced == 6)
        {
            StartCoroutine(MaxTowersPlaced());
        }
        if (wallet.money < 50 && towerSelected == false)
        {
            StartCoroutine(InsufficientFunds());
        }
    }

    public void SelectTowerL()
    {
        if (wallet.money >= 150 && maxTowers.towersPlaced < 6)
        {
            selectedTower = Instantiate(towerL);
            towerSelected = true;
            wallet.money -= 150;
        }
        if (maxTowers.towersPlaced == 6)
        {
            StartCoroutine(MaxTowersPlaced());
        }
        if (wallet.money < 150 && towerSelected == false)
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

    IEnumerator MaxTowersPlaced()
    {
        towerAmountError.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        towerAmountError.SetActive(false);
    }

}
