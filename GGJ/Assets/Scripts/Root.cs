using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Root : MonoBehaviour
{
    public bool breakable = true;
    public bool broken = false;
    public GameObject cutPrefab;
    public Transform cutPrefabPoint;
    public float speed = 1;

    private float currentTime;
    protected Animator anim;
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
                Instantiate(cutPrefab, cutPrefabPoint.position, Quaternion.identity);
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            broken = true;
            Debug.Log("Collided with " + collision.gameObject.name);
        }
    }
}

