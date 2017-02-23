using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        //уничтожение объекта, спавн эффекта взрыва
        GameObject explosionInstance = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Explose()
    {
        //GameObject explosionInstance = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        GameObject explosionInstance = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
