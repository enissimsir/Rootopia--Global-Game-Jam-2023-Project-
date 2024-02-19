using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseControl : MonoBehaviour
{
    Vector2 direction;
    Vector3 currentMousePos;

    private LineRenderer lineRenderer;
    private bool pressed = false;
    EdgeCollider2D edgeCollider;
    Vector2 mousePosDown;
    Vector2 mousePosUp;

    void Start()
    {
        edgeCollider = GetComponent<EdgeCollider2D>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosDown = Input.mousePosition;

            mousePosDown = Camera.main.ScreenToWorldPoint(mousePosDown);
            
            lineRenderer.SetPosition(0, mousePosDown);
            pressed = true;
        }
        if (Input.GetMouseButtonUp(0)){
            pressed = false;
            lineRenderer.SetPosition(0, new Vector2(0, 0));
            lineRenderer.SetPosition(1, new Vector2(0, 0));
        }
        if (pressed)
        {
            mousePosUp = Input.mousePosition;

            mousePosUp = Camera.main.ScreenToWorldPoint(mousePosUp);
            lineRenderer.SetPosition(1, mousePosUp);

            Ray ray = new Ray(mousePosDown, (mousePosUp - mousePosDown));
            RaycastHit2D hitData = Physics2D.Raycast(mousePosDown, (mousePosUp - mousePosDown), (mousePosUp - mousePosDown).magnitude);
            //Physics.Raycast(ray, out hitData, (mousePosUp - mousePosDown).magnitude);

            if (hitData && hitData.transform.tag == "Root")
            {
                Root root = hitData.transform.GetComponent<Root>();
                root.broken = true;
                //Debug.Log(hitData.transform.gameObject.name);
                
            }
        }
    }

}
