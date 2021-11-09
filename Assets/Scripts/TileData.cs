using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    //public int tileSpeed;
    public int gridX;
    public int gridY;

    private void OnMouseDown()
    {
        Debug.Log(gridX + "," + gridY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log(collision.gameObject.GetComponent<Circle>().blue);
            gameObject.GetComponent<Renderer>().material.color = new Color(collision.gameObject.GetComponent<Circle>().red, collision.gameObject.GetComponent<Circle>().green, collision.gameObject.GetComponent<Circle>().blue);
        }
    }

}
