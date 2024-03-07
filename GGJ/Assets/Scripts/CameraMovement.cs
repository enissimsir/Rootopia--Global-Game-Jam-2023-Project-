using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    private int currentWaypointIndex = 0;
    public GameObject[] waypoints;
    public float firstLookSpeed = 12.0f;
    public float speed = 1.0f;
    private float tmp = 0.0f;
    private bool isFirstTime = true;
    private bool startTheGame = false;
    private bool goOn = false;
    public static int currentLevel;

    private void Start()
    {
        GameState.levelStarted = true; // DO NOT FORGET TO REMOVE
        StartCoroutine(justWait(3));
        currentLevel = SceneManager.GetActiveScene().buildIndex - 1;
        if (currentLevel == 2)
            firstLookSpeed = firstLookSpeed * 1.5f;
    }

    private void Update()
    {
        FollowDividePoints();
        /*
        if (isFirstTime)
        {
            if (goOn)
                FirstLook();
        }
        else if (startTheGame)
        {
            if (goOn)
                FollowDividePoints();
        }
        else
        {
            StartCoroutine(justWait(2));
            startTheGame = true;
        } */
    }

    private void FirstLook()
    {
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f)
        {
            tmp++;
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                StartCoroutine(justWait(2));
                currentWaypointIndex = 0;
            }
            if (tmp == 3) isFirstTime = false;
        }
            if(Vector2.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) > 5.0f)
                transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, firstLookSpeed * Time.deltaTime);
            else
                transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, firstLookSpeed * Time.deltaTime / 3);
    }

    private void FollowDividePoints()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0.0f, GameObject.FindObjectOfType<DivideScript>().transform.position.y) , speed * Time.deltaTime);
    }

    private IEnumerator justWait(int waitTime)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        goOn = false;
        yield return new WaitForSeconds(waitTime);
        goOn = true;
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
