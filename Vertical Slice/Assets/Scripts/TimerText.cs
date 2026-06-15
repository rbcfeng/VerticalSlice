using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerText : MonoBehaviour
{
    [SerializeField] int timeLeft;
    [SerializeField] TMP_Text timertext;
    [SerializeField] private Timer gametime;
    [SerializeField] private ChangeScenes changeScenes;
    private bool endSceneLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        gametime.BeginTimer(timeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        timertext.text = gametime.GetTimeLeft().ToString();

        if (gametime.TimeFinished() && endSceneLoaded == false)
        {
            SceneManager.LoadScene(8);
            endSceneLoaded = true;
            Time.timeScale = 0;
        }

    }
}
