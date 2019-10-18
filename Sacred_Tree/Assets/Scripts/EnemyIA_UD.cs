using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA_UD : MonoBehaviour
{
    private GameObject gPlayer;
    // Start is called before the first frame update
    void Start()
    {
        gPlayer = GameObject.Find("Player");
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
            this.GetComponent<Animator>().SetTrigger("Attack");
        }
        else
        {
            //this.transform.position = Vector2.MoveTowards(this.transform.position, Spawn.transform.position, 3 * Time.deltaTime);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Range = 1;
    }
}
