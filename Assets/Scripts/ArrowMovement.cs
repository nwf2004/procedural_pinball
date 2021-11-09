using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public GameObject arrow;
    public bool right = true;
    public bool moveReady = true;
    IEnumerator Coroutine()
    {


        moveReady = false;
        yield return new WaitForSeconds(.01f);
        moveReady = true;


    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moveReady == true)
        {
            if (right == false)
            {
                arrow.transform.position = new Vector3(transform.position.x + -0.2f, transform.position.y, 0);
                if (arrow.transform.position.x <= -18)
                {
                    right = true;
                }
            }
            if (right == true)
            {
                arrow.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, 0);
                if (arrow.transform.position.x >= 17)
                {
                    right = false;
                }
            }
            StartCoroutine(Coroutine());

        }
    }
}
    

