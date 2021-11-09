using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float red = 0.0f;
    public float green = 0.0f;
    public float blue = 0.0f;
    // Start is called before the first frame xupdate
    void Start()
    {
    red = Random.Range(0.0f, 1.0f);
    green = Random.Range(0.0f, 1.0f);
    blue = Random.Range(0.0f, 1.0f);
}
}
