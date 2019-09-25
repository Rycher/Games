using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilArrow : MonoBehaviour
{
    private Vector2 posw;
    private Vector2 posPlayer;
    // Start is called before the first frame update
    void Start()
    {
        posw = GameObject.Find("SwHitbox").transform.position;
        posPlayer = GameObject.Find("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (posw.x < posPlayer.x)
        {
            transform.Translate(Vector3.left * 20 * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * 20 * Time.deltaTime);            
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //int arrowid = gameObject.GetInstanceID();
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.GetComponent<Rigidbody2D>().Sleep();
        }
    }

   
}
