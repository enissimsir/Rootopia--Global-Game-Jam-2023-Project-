using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMapManagement : MonoBehaviour
{
    public static bool[] isCompleted = new bool[3] { false, false, false };
    public Button hottyButton;
    public Button slimyButton;

    void Start()
    {
        hottyButton.interactable = false;
        slimyButton.interactable = false;
        if (isCompleted[0])
        {
            hottyButton.interactable = true;
        }
        if (isCompleted[1])
        {
            slimyButton.interactable = true;
        }
    }

    void Update()
    {
        
    }
}
