using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{

    [Header("Icy")]
    public Image icyYildiz;
    public Image icyYildizComplete;
    public Image blueDiaObjective;
    public Image blueDiaObjectiveComplete;
    public Image blueBubbleObjective;
    public Image blueBubbleObjectiveComplete;

    [Header("Lava")]
    public Image lavaYildiz;
    public Image lavaYildizComplete;
    public Image redKuvarsObjective;
    public Image redKuvarsObjectiveComplete;
    public Image redStickObjective;
    public Image redStickObjectiveComplete;

    [Header("Slime")]
    public Image slimeYildiz;
    public Image slimeYildizComplete;
    public Image greenKuvarsObjective;
    public Image greenKuvarsObjectiveComplete;
    public Image orangeKuvarsObjective;
    public Image orangeKuvarsObejctiveComplete;

    public static ObjectiveManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    
}
