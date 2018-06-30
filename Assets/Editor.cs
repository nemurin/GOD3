using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Editor : MonoBehaviour
{
    // bullet prefab
    public GameObject jimen;
    public GameObject[] gimic_stock;
    public GameObject canvas;
    public Image sign_img;
    public Sprite[] img_stock;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (jimen == gimic_stock[25])
            {
                sign_img.sprite = img_stock[26];
                jimen = gimic_stock[26];
            }

            else if (jimen == gimic_stock[26])
            {
                sign_img.sprite = img_stock[27];
                jimen = gimic_stock[27];
            }
            else if (jimen == gimic_stock[27])
            {
                sign_img.sprite = img_stock[28];
                jimen = gimic_stock[28];
            }
            else
            {
                sign_img.sprite = img_stock[25];
                jimen = gimic_stock[25];
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (jimen == gimic_stock[21])
            {
                sign_img.sprite = img_stock[22];
                jimen = gimic_stock[22];
            }
            else
            {
                sign_img.sprite = img_stock[21];
                jimen = gimic_stock[21];
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (jimen == gimic_stock[0])
            {
                sign_img.sprite = img_stock[23];
                jimen = gimic_stock[23];
            }
            else if (jimen == gimic_stock[23])
            {
                sign_img.sprite = img_stock[24];
                jimen = gimic_stock[24];
            }
            else
            {
                sign_img.sprite = img_stock[0];
                jimen = gimic_stock[0];
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (jimen == gimic_stock[1])
            {
                sign_img.sprite = img_stock[2];
                jimen = gimic_stock[2];
            }
            else if (jimen == gimic_stock[2])
            {
                sign_img.sprite = img_stock[3];
                jimen = gimic_stock[3];
            }
            else if (jimen == gimic_stock[3])
            {
                sign_img.sprite = img_stock[4];
                jimen = gimic_stock[4];
            }
            else
            {
                sign_img.sprite = img_stock[1];
                jimen = gimic_stock[1];
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (jimen == gimic_stock[13])
            {
                sign_img.sprite = img_stock[14];
                jimen = gimic_stock[14];
            }
            else if (jimen == gimic_stock[12])
            {
                sign_img.sprite = img_stock[13];
                jimen = gimic_stock[13];
            }
            else if (jimen == gimic_stock[6])
            {
                sign_img.sprite = img_stock[12];
                jimen = gimic_stock[12];
            }
            else if (jimen == gimic_stock[9])
            {
                sign_img.sprite = img_stock[10];
                jimen = gimic_stock[10];
            }
            else if (jimen == gimic_stock[10])
            {
                sign_img.sprite = img_stock[11];
                jimen = gimic_stock[11];
            }
            else if (jimen == gimic_stock[5])
            {
                sign_img.sprite = img_stock[9];
                jimen = gimic_stock[9];
            }
            else if (jimen == gimic_stock[15])
            {
                sign_img.sprite = img_stock[16];
                jimen = gimic_stock[16];
            }
            else if (jimen == gimic_stock[16])
            {
                sign_img.sprite = img_stock[17];
                jimen = gimic_stock[17];
            }
            else if (jimen == gimic_stock[7])
            {
                sign_img.sprite = img_stock[15];
                jimen = gimic_stock[15];
            }
            else if (jimen == gimic_stock[18])
            {
                sign_img.sprite = img_stock[19];
                jimen = gimic_stock[19];
            }
            else if (jimen == gimic_stock[19])
            {
                sign_img.sprite = img_stock[20];
                jimen = gimic_stock[20];
            }
            else if (jimen == gimic_stock[8])
            {
                sign_img.sprite = img_stock[18];
                jimen = gimic_stock[18];
            }

        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (jimen == gimic_stock[5])
            {
                sign_img.sprite = img_stock[6];
                jimen = gimic_stock[6];
            }
            else if (jimen == gimic_stock[6])
            {
                sign_img.sprite = img_stock[7];
                jimen = gimic_stock[7];
            }
            else if (jimen == gimic_stock[7])
            {
                sign_img.sprite = img_stock[8];
                jimen = gimic_stock[8];
            }
            else
            {
                sign_img.sprite = img_stock[5];
                jimen = gimic_stock[5];
            }
        }
            if (Input.GetMouseButtonDown(0))
        {
            print("左ボタンが押されている");
            GameObject jimen2 = Instantiate(jimen, new Vector3((int)((Input.mousePosition.x) / 32) * 32+16, (int)((Input.mousePosition.y) / 32) * 32+16, Input.mousePosition.z), Quaternion.identity);
            jimen2.transform.SetParent(canvas.transform, false);
            print(new Vector3((int)((Input.mousePosition.x - 512) / 32) * 32, (int)((Input.mousePosition.y - 384) / 32) * 32, Input.mousePosition.z));
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GameObject result = null;
            print("右ボタンが押されている");
            Collider2D collition2d = Physics2D.OverlapPoint(new Vector2((int)((Input.mousePosition.x)), (int)((Input.mousePosition.y))));
            if (collition2d)
            {
                result = collition2d.transform.gameObject;
            }
            if(result.name!="Player"&&result!=null)Destroy(result);
        }
    }
}
