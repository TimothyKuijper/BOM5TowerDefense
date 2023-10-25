using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayMoney : MonoBehaviour
{
    [SerializeField] private Wallet wallet;
    [SerializeField] private TMP_Text walletDisplay;

    void Update()
    {
        walletDisplay.text = "Balance: $" + wallet.money;
    }
}
