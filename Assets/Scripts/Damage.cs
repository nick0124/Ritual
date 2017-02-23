using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

    public int damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<Health>()!=null)
        {
            coll.gameObject.GetComponent<Health>().health -= damage;
        }

        //если наносим дамаг и есть анимация, то ставим что нанесли урон
        //отменяем с помощью события в анимации
        if (coll.gameObject.name == "Player")
        {
            coll.gameObject.GetComponent<Animator>().Play("TakeDamage");
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.GetComponent<Health>() != null)
        {
            coll.gameObject.GetComponent<Health>().health -= damage;
        }
    }
}
