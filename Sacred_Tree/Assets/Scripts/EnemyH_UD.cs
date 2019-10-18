using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH_UD : MonoBehaviour
{
    [SerializeField]
    Transform LifeBar;
    [SerializeField]
    public float ValLife = 0.5f;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arma")
        {
            
            LifeBar.transform.position = new Vector3(LifeBar.transform.position.x, LifeBar.transform.position.y - 0.025f, LifeBar.transform.position.z);
            LifeBar.localScale = new Vector3(LifeBar.localScale.x, LifeBar.localScale.y - 0.05f, LifeBar.localScale.z);
            ValLife = LifeBar.localScale.y;
            if (ValLife <= 0)
            {
                Destroy(this.gameObject);
            }
        }

        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Animator>().SetTrigger("Attack");
            Debug.Log("Teste");
        }       
    }
}
