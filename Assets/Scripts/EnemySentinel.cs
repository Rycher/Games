using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySentinel : MonoBehaviour
{
    public float speed;
    public float distance;
    private int iSentinelArea;
    private int Enemyid;
    public Vector2 posInic;
    private bool exitP = false;
    //public Transform groundDetection;
    // Start is called before the first frame update
    void Start()
    {
        posInic = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.GetInstanceID() == Enemyid)
        {            

            if (gameObject.transform.position.x == posInic.x)
            {
                exitP = false;
                if (transform.position.x < posInic.x)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                    GetComponent<SpriteRenderer>().flipX = false;
                }
            }

            if (exitP == true)
            {
                if (transform.position.x < posInic.x)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                    GetComponent<SpriteRenderer>().flipX = false;
                }               
                this.transform.position = Vector2.MoveTowards(this.transform.position, posInic, 1 * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        // groundInfo = Physics2D.Raycast(groundDetection.position,Vector2.down, distance);     

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SentinelArea")
        {
            //Debug.Log("Saiu do trigger");
            iSentinelArea = 1;
            Enemyid = this.gameObject.GetInstanceID();
            //Debug.Log("Inverter posição");
            if (gameObject.GetInstanceID() == Enemyid)
            {
                if (transform.eulerAngles.y == 180)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }
        }

        if (collision.gameObject.name == "Player")
        {
            if (gameObject.GetInstanceID() == Enemyid)
            {
                exitP = true;
            }
        }

    }
        private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SentinelArea")
        {
            iSentinelArea = 0;
        }       
        //Debug.Log(collision.gameObject.name);
    }
    
}
