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
    public GameObject purchaseButton;
    public TMP_Text moneyUI;
    int amount_of_money;
    bool collectedGameBoy;

    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompletedFriendQuest()
    {
        collectedGameBoy = true;
    }
     public void Purchase()
    {
        amount_of_money = (int)Variables.Application.Get("amount of money");
        collectedGameBoy = (bool)Variables.Application.Get("collectedGameConsole");
        
        if (amount_of_money >= price)
        {
            Debug.Log(moneyUI);
            amount_of_money -= price;
            moneyUI.text = amount_of_money.ToString();
            retro_game_console.SetActive(false);
            purchaseButton.SetActive(false);
            collectedGameBoy = true;
            CompletedFriendQuest();

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
