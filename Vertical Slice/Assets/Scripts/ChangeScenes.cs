using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void ToOfficeEntrance()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMainOffice()
    {
        SceneManager.LoadScene(0);
    }

    public void ToThriftStore()
    {
        SceneManager.LoadScene(2);
    }

    public void ToConferenceRoom()
    {
        SceneManager.LoadScene(3);
    }

    public void ToBreakRoom()
    {
        SceneManager.LoadScene(4);
    }
}
