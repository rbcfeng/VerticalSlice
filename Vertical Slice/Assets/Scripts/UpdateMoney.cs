using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UpdateMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text moneyUI;
    int amount_of_money;
    // Start is called before the first frame update
    void Start()
    {
        amount_of_money = (int)Variables.Application.Get("amount of money");
        moneyUI.text = amount_of_money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateAmount();
        //moneyUI.text = amount_of_money.ToString();
    }

    public void UpdateAmount()
    {
        amount_of_money = (int)Variables.Application.Get("amount of money");
        moneyUI.text = amount_of_money.ToString();
    }
}
