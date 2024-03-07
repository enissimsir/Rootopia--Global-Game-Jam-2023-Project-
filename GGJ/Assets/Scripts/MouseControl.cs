using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseControl : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private bool pressed = false;
    Vector2 mousePosDown;
    Vector2 mousePosUp;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosDown = Input.mousePosition;

            mousePosDown = Camera.main.ScreenToWorldPoint(mousePosDown);

            lineRenderer.SetPosition(0, new Vector3(mousePosDown.x, mousePosDown.y, 8.0f));
            pressed = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
            lineRenderer.SetPosition(0, new Vector3(0, 0, 8.0f));
            lineRenderer.SetPosition(1, new Vector3(0, 0, 8.0f));
        }
        if (pressed)
        {
            mousePosUp = Input.mousePosition;

            mousePosUp = Camera.main.ScreenToWorldPoint(mousePosUp);
            lineRenderer.SetPosition(1, new Vector3(mousePosUp.x, mousePosUp.y, 8.0f));

            Ray ray = new Ray(mousePosDown, (mousePosUp - mousePosDown));
            RaycastHit2D[] hitDatas = Physics2D.RaycastAll(mousePosDown, (mousePosUp - mousePosDown), (mousePosUp - mousePosDown).magnitude);

            foreach (var hitData in hitDatas)
            {
                if (hitData && hitData.transform.tag == "Root")
                {
                    Root root = hitData.transform.GetComponent<Root>();
                    if (root != null)
                    {
                        root.broken = true;
                    }
                    else
                    {
                        root = hitData.transform.parent.GetComponent<Root>();
                        root.broken = true;
                    }

                    Debug.Log(hitData.transform.gameObject.name);

                }
            }
        }
    }

}
