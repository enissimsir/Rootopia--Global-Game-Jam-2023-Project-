using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject dividePoint;

    void Start()
    {
        StartCoroutine(Stop());
    }

    private IEnumerator Stop()
    {
        yield return new WaitForSeconds(8);
        Instantiate(dividePoint, gameObject.transform);
    }
}
