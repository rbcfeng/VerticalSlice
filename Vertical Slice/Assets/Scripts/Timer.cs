using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class Timer : MonoBehaviour
{
    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
    }

    public void BeginTimer(float startTime)
    {
        timeLeft = startTime;
    }

    public float GetTimeLeft()
    {
        return timeLeft;
    }

    public bool TimeFinished()
    {
        if (timeLeft < 0)
        {
            return true;
        }
            else
            {
                return false;
            }
    }
}
