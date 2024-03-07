using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DivideScript : MonoBehaviour
{
    public GameObject right;
    public GameObject left;
    public GameObject mid;
    public GameObject dividePoint;

    private GameObject[] roots;

    private void Start()
    {
        StartCoroutine(Divide());

    }

    IEnumerator Divide()
    {
        GameObject[] roots = new GameObject[3] {
            Instantiate(left, transform),
            Instantiate(mid, transform),
            Instantiate(right, transform),
        };
        yield return new WaitForSeconds(Controller.timeTodivide);

        MakeNextDividePoint(roots);
    }

    //private void Update()
    //{
    //    for (int i = 0; i < 3; i += 1)
    //    {
    //        var root = transform.GetChild(i).GetComponent<RootClass>();

    //        if (root.broken)
    //        {
    //            Debug.Log("Broken");
    //            root.breakable = false;
    //        }
    //        else root.breakable = true;
    //    }
    //}
    void MakeNextDividePoint(GameObject[] roots)
    {
        int nextState = 0;
        if (Controller.debug)
        {
            int index = -1;
            Vector3 position;

            for (int i = 0; i < 3; i++)
            {
                var root = transform.GetChild(i).GetComponent<Root>();

                if (root.broken)
                {
                    nextState++;
                }
                else
                    index = i;
            }

            switch (index)
            {
                case 0:
                    position = roots[2 - index].transform.position + new Vector3(-2.16f, -1.44f, 0);
                    break;
                case 1:
                    position = roots[2 - index].transform.position + new Vector3(0, -1.44f, 0);
                    break;
                case 2:
                    position = roots[2 - index].transform.position + new Vector3(2.16f, -1.44f, 0);
                    break;
                default:
                    position = Vector3.zero;
                    break;
            }

            foreach (var root in roots)
            {
                root.transform.parent = null;
            }

            if (nextState == 2)
            {
                Instantiate(dividePoint, position, Quaternion.identity);
                Debug.Log("index " + index + " name " + transform.name);
                Destroy(transform.gameObject);
            }
            else
            {
                GameState.gameOver = true;
                SceneManager.LoadScene(5);
            }
        }
    }

}
