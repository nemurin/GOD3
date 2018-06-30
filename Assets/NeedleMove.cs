using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleMove : MonoBehaviour {
    public int linex, liney, movex, movey,firstx,firsty;
    public LayerMask playerLayer;
    bool moving = false;
    public Player player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player= GameObject.Find("Player").GetComponent<Player>();
        if (!moving)
        {
            firstx = (int)transform.position.x;
            firsty = (int)transform.position.y;
        }
        bool touched = Physics2D.Linecast(transform.position, transform.position + new Vector3(linex, liney, 0), playerLayer);
        if (touched || moving)
        {

            transform.position += new Vector3(movex, movey, 0);
            moving = true;
        }
        if (player.death == true)
        {
            moving = false;
            transform.position = new Vector3(firstx,firsty,0);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        transform.position = new Vector3(firstx, firsty, 0);
        moving = false;
    }
}
