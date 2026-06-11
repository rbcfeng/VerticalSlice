using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightsButton : MonoBehaviour
{
    public TMP_Text lights_UI;
    public GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleLights()
    {
        if (lights_UI.text == "LIGHTS: ON")
        {
            lights.SetActive(true);
            lights_UI.text = "LIGHTS: OFF";
        }
        else if (lights_UI.text == "LIGHTS: OFF")
        {
            lights.SetActive(false);
            lights_UI.text = "LIGHTS: ON";
        }
    }
}
