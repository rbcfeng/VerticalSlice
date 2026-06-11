using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UpdateMoney : MonoBehaviour
{
    public TMP_Text moneyUI;
    public int amount_of_money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //amount_of_money = (int)Variables.Application.Get("amount of money");
        //moneyUI.text = amount_of_money.ToString();
    }

    public void UpdateAmount()
    {
        moneyUI.text = amount_of_money.ToString();
    }
}
