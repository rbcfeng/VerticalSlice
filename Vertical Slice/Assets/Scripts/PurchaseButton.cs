using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PurchaseButton : MonoBehaviour
{
    public int price;
    public GameObject cannot_purchase;
    public GameObject retro_game_console;
    public GameObject Boss;
    public GameObject purchaseButton;
    public TMP_Text moneyUI;
    int amount_of_money;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Purchase()
    {
        amount_of_money = (int)Variables.Scene(Boss).Get("amount of money");
        Debug.Log("Clicked on Purchase");
        if (amount_of_money >= price)
        {
            amount_of_money -= 5;
            moneyUI.text = amount_of_money.ToString();
            retro_game_console.SetActive(false);
            purchaseButton.SetActive(false);

        }
        else
        {
            StartCoroutine(CannotPurchase(1f));
        }
    }

    IEnumerator CannotPurchase(float waitTime)
    {
        cannot_purchase.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        cannot_purchase.SetActive(false);
    }
}
