using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JimenAwake : MonoBehaviour {
    public Image jimen;
    public Sprite jimensp;
    public Sprite none;
    public Player player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("Player").GetComponent<Player>();
        if (player.death == true) { jimen.sprite = none; }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (jimen.sprite == jimensp)
            {
                jimen.sprite = none;
            }
            else
            {
                jimen.sprite = jimensp;
            }
        }
        }
    void OnCollisionEnter2D(Collision2D other)
    {
        jimen.sprite = jimensp;
    }
}
