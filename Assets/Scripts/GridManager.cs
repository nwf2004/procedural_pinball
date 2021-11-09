using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public bool playerReady = true;

    public GameObject tilePrefab;
    public GameObject player;
    //public Sprite[] tileSprites;

    GameObject[,] gridTiles;

    public int gridWidth;
    public int gridHeight;

    IEnumerator Coroutine()
    {


        playerReady = false;
        yield return new WaitForSeconds(.1f);
        playerReady = true;


    }
    // Start is called before the first frame update
    void Start()
    {
        gridTiles = new GameObject[gridWidth, gridHeight];
        for(int x = 0; x < gridWidth; x++)
        {
            for(int y = 0; y < gridHeight; y++)
            {
                MakeTile(x, y);
            }
        }
        //Debug.Log(gridTiles[0, 0].GetComponent<SpriteRenderer>().sprite);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && playerReady == true)
        {
            {
                GameObject newPlayer = Instantiate(player);
                newPlayer.transform.position = new Vector3(GameObject.Find("Arrow").transform.position.x, 10, 0);
                newPlayer.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 1000);
                StartCoroutine(Coroutine());
            }
        }

    }

    void MakeTile(int xPos, int yPos) {
        GameObject newTile = Instantiate(tilePrefab);

        //int randTile = Random.Range(0, tileSprites.Length);
        //newTile.GetComponent<SpriteRenderer>().sprite = tileSprites[randTile];
        newTile.transform.position = new Vector3(transform.position.x + xPos + Random.Range(5, 5), transform.position.y + yPos, 0);
        newTile.GetComponent<Rigidbody2D>();
        HingeJoint2D HJ2D = newTile.GetComponent<HingeJoint2D>();
        var MTR = HJ2D.motor;
        MTR.motorSpeed = Random.Range(10, 1000);
        HJ2D.motor = MTR;
        TileData myData = newTile.GetComponent<TileData>();
        /*if(randTile == 0)
        {
            myData.tileSpeed = 4;
        } else if(randTile == 1)
        {
            myData.tileSpeed = 1;
        } else if(randTile == 2)
        {
            myData.tileSpeed = 7;
        }
        */
        myData.gridX = xPos;
        myData.gridY = yPos;
        gridTiles[xPos, yPos] = newTile;
    }
}
