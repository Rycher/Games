using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyIA_RE : MonoBehaviour
{
    private Transform target;
    private Transform RotaTarget;        
    private int SPlayer;
    GameObject Spawn;
    int Range;
    // Start is called before the first frame update
    void Start()
    {
       
        Spawn = GameObject.Find("SpawnRedEye1");
        //Rota = r.Next(0, 1);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //RotaEnemy();       
    }

    // Update is called once per frame
    void Update()
    {

        //if (Range != 0)
        //{         

        //    this.transform.position = Vector2.MoveTowards(this.transform.position, Spawn.transform.position, 3 * Time.deltaTime);
        //}

        RotaEnemy();
    }

    void RotaEnemy()
    {
        //if (Rota == 0)
        //{
            
            //this.GetComponent<SpriteRenderer>().flipX = false;
        //}
        //else
        //{
        //    this.transform.Translate(Vector2.right * 1 * Time.deltaTime);
        //    this.GetComponent<SpriteRenderer>().flipX = true;
        //}        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Range = 0;
            this.transform.position = Vector2.MoveTowards(this.transform.position, target.position, 2 * Time.deltaTime);

            if (this.transform.position.x < target.transform.position.x)
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

        }
        else
        {
            
            //this.transform.position = Vector2.MoveTowards(this.transform.position, Spawn.transform.position, 3 * Time.deltaTime);
        }
        

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Range = 1;        
    }
}
