using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MineralCollecter : MonoBehaviour
{
    private int score;
    private int currentLevel;
    private int totalScore;
    public AudioSource[] buzulCollects;
    public AudioSource[] lavaCollects;
    public AudioSource[] slimeCollects;

    void Start()
    {
        score = 0;
        currentLevel = SceneManager.GetActiveScene().buildIndex - 1;
        if (currentLevel == 1)
            totalScore = 4;
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mineral")
        {
            if (currentLevel == 1)
            {
                if (score < buzulCollects.Length)
                    buzulCollects[score].Play();
                else
                    buzulCollects[0].Play();
            }
            else if (currentLevel == 2)
            {
                if (score < lavaCollects.Length)
                    lavaCollects[score].Play();
                else
                    lavaCollects[0].Play();
            }
            else
            {
                if (score < slimeCollects.Length)
                    slimeCollects[score].Play();
                else
                    slimeCollects[0].Play();
            }
            Destroy(collision.transform.parent.gameObject);
            score++;
        }

    }
}
