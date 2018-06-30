using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JimenDelete : MonoBehaviour {
    public Image Delete;
    public BoxCollider2D box2d;
    public Sprite jimensp;
    public Sprite none;
    public Player player;
    void Update()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        if (player.death == true) { Delete.sprite = jimensp;
            box2d.enabled = true;
        }
    }
        void OnCollisionEnter2D(Collision2D other)
    {
        //Delete.SetActive(false);
        box2d.enabled = false;
        Delete.sprite = none;
    }
}
