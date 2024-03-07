using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonManager : MonoBehaviour
{
    public Canvas level1Objective;
    public Canvas level2Objective;
    public Canvas level3Objective;

    public AudioSource efekt;


    public void StartGame()
    {
        efekt.Play();
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        efekt.Play();
        Application.Quit();
    }
    public void Level1()
    {
        efekt.Play();
        SceneManager.LoadScene(2);
        level1Objective.gameObject.SetActive(false);
    }
    public void Level2()
    {
        efekt.Play();
        SceneManager.LoadScene(3);
        level2Objective.gameObject.SetActive(false);
    }
    public void Level3()
    {
        efekt.Play();
        SceneManager.LoadScene(4);
        level3Objective.gameObject.SetActive(false);
    }

    public void Level1Objective()
    {
        efekt.Play();
        level1Objective.gameObject.SetActive(true);
    }

    public void Level2Objective()
    {
        efekt.Play();
        level2Objective.gameObject.SetActive(true);
    }

    public void Level3Objective()
    {
        efekt.Play();
        level3Objective.gameObject.SetActive(true);
    }

    public void Back()
    {
        efekt.Play();
        level1Objective.gameObject.SetActive(false);
        level2Objective.gameObject.SetActive(false);
        level3Objective.gameObject.SetActive(false);
    }
}
