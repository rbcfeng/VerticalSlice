using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideTransition : MonoBehaviour
{
    public List<GameObject> slidesList = new List<GameObject>();
    public int currentSlide;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            slidesList.Add(child.gameObject);
        }

        currentSlide = 0;
        slidesList[currentSlide].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextSlide();
        }
    }

    public void NextSlide()
    {
        if (currentSlide == 6)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            slidesList[currentSlide].SetActive(false);
            currentSlide ++;
            slidesList[currentSlide].SetActive(true);
        }
    }
}
