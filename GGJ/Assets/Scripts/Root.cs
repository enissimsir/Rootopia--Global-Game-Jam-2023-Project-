using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    public bool breakable = true;
    public bool broken = false;
    protected Animator anim;
    public float speed = 1;
    private float currentTime;
    public GameObject cutPrefab;

    bool once = false;
    void Start()
    {
        currentTime = Time.time;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.debug)
            if (Controller.timeTodivide + currentTime >= Time.time) { }
            //transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            else breakable = false;

        if (breakable)
        {
            if (broken && !once)
            {
                Instantiate(cutPrefab, transform.GetChild(0).position, Quaternion.identity);
                StartCoroutine(animation());
                once = true;
            }
        }
    }
    IEnumerator animation()
    {
        yield return new WaitForSeconds(0.087f);
        anim.speed = 0;
    }
}

