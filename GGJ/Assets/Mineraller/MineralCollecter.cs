using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MineralCollecter : MonoBehaviour
{
    public int blueDiaCounter = 0;
    public int blueBubbleCounter = 0;
    public int redKuvarsCounter = 0;
    public int redstickCounter = 0;
    public int purpleKuvarsCounter = 0;
    public int orangeKuvarsCounter = 0;
    public int yesimcounter = 0;

    public AudioSource blueBubble;
    public AudioSource blueDia;
    public AudioSource redStick;
    public AudioSource redCuvars;
    public AudioSource orangeCuvars;
    public AudioSource purpleCuvars;
    public AudioSource middleFinger;

    /*
    public static MineralCollecter Instance { get; private set; }
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
    */
   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BlueDia")
        {
            blueDia.Play();
            blueDiaCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(1f, collision.gameObject));
        }

        if (collision.gameObject.tag == "BlueBubble")
        {
            blueBubble.Play();
            blueBubbleCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(0.9f, collision.gameObject));
        }

        if (collision.gameObject.tag == "RedKuvars")
        {
            redCuvars.Play();
            redKuvarsCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(1.2f, collision.gameObject));
        }

        if (collision.gameObject.tag == "RedStick")
        {
            redStick.Play();
            redstickCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(1f, collision.gameObject));
        }

        if (collision.gameObject.tag == "PurpleKuvars")
        {
            purpleCuvars.Play();
            purpleKuvarsCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(1.5f, collision.gameObject));
        }

        if (collision.gameObject.tag == "OrangeKuvars")
        {
            orangeCuvars.Play();
            orangeKuvarsCounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(0.9f, collision.gameObject));
        }

        if (collision.gameObject.tag == "Yesim")
        {
            middleFinger.Play();
            yesimcounter++;
            collision.GetComponent<Animator>().Play("Collect");
            StartCoroutine(AnimWait(1.5f, collision.gameObject));
        }
    }

    private IEnumerator AnimWait(float animLength, GameObject mineral)
    {       
        yield return new WaitForSeconds(animLength);
        Destroy(mineral);
    }
}
