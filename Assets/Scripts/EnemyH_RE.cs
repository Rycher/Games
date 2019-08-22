using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH_RE : MonoBehaviour
{
    [SerializeField]
    Transform LifeBar;
    [SerializeField]
    public float ValLife ;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arma")
        {
            
            LifeBar.transform.position = new Vector3(LifeBar.transform.position.x - 0.12f, LifeBar.transform.position.y , LifeBar.transform.position.z);
            LifeBar.localScale = new Vector3(LifeBar.localScale.x - 0.2f, LifeBar.localScale.y , LifeBar.localScale.z);
            ValLife = LifeBar.localScale.x;
            if (ValLife <= 0)
            {
                Destroy(this.gameObject);
            }
        }

        if (collision.gameObject.tag == "Arrow")
        {

            LifeBar.transform.position = new Vector3(LifeBar.transform.position.x, LifeBar.transform.position.y - 0.1f, LifeBar.transform.position.z);
            LifeBar.localScale = new Vector3(LifeBar.localScale.x, LifeBar.localScale.y - 0.2f, LifeBar.localScale.z);
            ValLife = LifeBar.localScale.y;
            if (ValLife <= 0)
            {
                Destroy(this.gameObject);
            }
        }


        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

    }
}
