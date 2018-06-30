using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
    public Image player;
    public Rigidbody2D rig2d;
    public LayerMask killLayer;
    public LayerMask jimenLayer;
    public bool touched;
    public bool grounded;
    public bool death;
    public bool needledeath;
    public bool jumping;
    // Use this for initialization
    void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.Linecast(transform.position, transform.position - new Vector3(0, 40, 0), jimenLayer);
        if (grounded) { jumping = false; }
        if (Input.GetKeyDown("space")&&grounded)
        {
            rig2d.AddForce(Vector2.up * 32000);
            jumping = true;
        }
        else if (Input.GetKeyDown("space") &&jumping)
        {
            //rig2d.AddForce(Vector2.up * 28000);
            jumping = false;
        }
        touched = Physics2D.Linecast(transform.position, transform.position - new Vector3(1, 0, 0) * 18, jimenLayer)
             ||Physics2D.Linecast(transform.position - new Vector3(0, 16, 0), transform.position - new Vector3(18, 16, 0), jimenLayer);
        if (touched == false)
        {
            if(Input.GetKey(KeyCode.LeftArrow)) player.transform.localPosition -= new Vector3(3, 0, 0);
        }
        bool righttouched = Physics2D.Linecast(transform.position, transform.position + new Vector3(1, 0, 0) * 18, jimenLayer)
             || Physics2D.Linecast(transform.position - new Vector3(0, 16, 0), transform.position + new Vector3(18, 16, 0), jimenLayer);
        if (righttouched == false)
        {
            if (Input.GetKey(KeyCode.RightArrow)) player.transform.localPosition += new Vector3(3, 0, 0);
        }
        death = false;
        // GameObject型の配列cubesに、"box"タグのついたオブジェクトをすべて格納
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("jimen");
        if (player.transform.position.y < 0|| needledeath == true)
        {
            Debug.Log("killed");
            player.transform.localPosition = new Vector3(-300, 0, 0);
            death = true;
            needledeath = false;

            // GameObject型の変数cubeに、cubesの中身を順番に取り出す。
            // foreachは配列の要素の数だけループします。
            foreach (GameObject cube in cubes)
            {
                cube.SetActive(true);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "killer")
        {
            Debug.Log("killed");
            player.transform.localPosition = new Vector3(-300, 0, 0);
        }
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("toched"); if (other.gameObject.tag == "killer")
        {
            needledeath = true;
            Debug.Log("killed");
            player.transform.localPosition = new Vector3(-300, 0, 0);
            death = true;

            // GameObject型の配列cubesに、"box"タグのついたオブジェクトをすべて格納
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("jimen");

            // GameObject型の変数cubeに、cubesの中身を順番に取り出す。
            // foreachは配列の要素の数だけループします。
            foreach (GameObject cube in cubes)
            {
                cube.SetActive(true);
            }
        
        }
    }
}
