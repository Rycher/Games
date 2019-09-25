using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH_RE : MonoBehaviour
{
    int atacado = 0;
    float waitTime = 0.5f;
    float timer;
    [SerializeField]
    Transform LifeBar;
    [SerializeField]
    public float qtdLife;
    private float ValLife;
    // Start is called before the first frame update
    void Update()
    {
        
        if (atacado == 1)
        {
            
            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                Destroy(this.gameObject);
            }
        }
        
        Debug.Log(timer);        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arma")
        {
            this.gameObject.GetComponent<Animator>().SetBool("Atacado", true);
            //LifeBar.transform.position = new Vector3(LifeBar.transform.position.x - 0.12f, LifeBar.transform.position.y , LifeBar.transform.position.z);
            //LifeBar.localScale = new Vector3(LifeBar.localScale.x - 0.2f, LifeBar.localScale.y , LifeBar.localScale.z);
            ValLife -= 2;
            qtdLife = ValLife;

            if (ValLife <= 0)
            {               
                atacado = 1;
            }
        }

        //if (collision.gameObject.tag == "Arrow")
        //{

        //    LifeBar.transform.position = new Vector3(LifeBar.transform.position.x, LifeBar.transform.position.y - 0.1f, LifeBar.transform.position.z);
        //    LifeBar.localScale = new Vector3(LifeBar.localScale.x, LifeBar.localScale.y - 0.2f, LifeBar.localScale.z);
        //    ValLife = LifeBar.localScale.y;
        //    if (ValLife <= 0)
        //    {
        //        Destroy(this.gameObject);
        //    }
        //}


        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
   
}
