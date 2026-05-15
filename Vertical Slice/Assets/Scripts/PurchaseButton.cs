using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    public int price = 5;
    public GameObject cannot_purchase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnClick()
    {
        if (MoneyManager.amount_of_money == 5)
        {
            MoneyManager.amount_of_money -= 5;
        }
        else
        {
            cannot_purchase.SetActive(true);
            yield return new WaitForSeconds(2);
            cannot_purchase.SetActive(false);
        }
    }
}
