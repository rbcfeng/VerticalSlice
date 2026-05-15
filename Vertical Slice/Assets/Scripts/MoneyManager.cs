using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static int amount_of_money = 0;

    public delegate void EarnedMoneyDelegate();
    public event EarnedMoneyDelegate EarnedMoney;

    void Start()
    {
        
    }

    void Update()
    {
        //if (completedQuest == true):

    }



}
