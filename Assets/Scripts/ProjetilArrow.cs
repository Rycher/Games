using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 15 * Time.deltaTime);
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
