using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject dividePointPrefab;
    public Transform devidePointPos;

    private bool once = false;

    void Start()
    {
        GameState.levelStarted = false;
        GameState.gameOver= false;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameState.levelStarted && !once)
        {
            Debug.Log("Game Started");
            Instantiate(dividePointPrefab, devidePointPos.position, Quaternion.identity);
            once = true;
        }
        if (GameState.gameOver)
        {
            Debug.Log("Game Over");

        }else if(GameState.victory)
        {
            Debug.Log("Victory. Next level...");
        }
    }
}
