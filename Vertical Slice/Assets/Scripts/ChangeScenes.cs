using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void ToOfficeEntrance()
    {
        SceneManager.LoadScene(3);
    }

    public void ToMainOffice()
    {
        SceneManager.LoadScene(2);
    }

    public void ToThriftStore()
    {
        SceneManager.LoadScene(4);
    }

    public void ToConferenceRoom()
    {
        SceneManager.LoadScene(5);
    }

    public void ToBreakRoom()
    {
        SceneManager.LoadScene(6);
    }

    public void ToPark()
    {
        SceneManager.LoadScene(1);
    }
}
