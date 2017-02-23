using UnityEngine;
using System.Collections;

public class DestroingPlatform : MonoBehaviour {

    public float destroyTime;
    public bool destroy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (destroy)
        {
            destroyTime -= Time.deltaTime;
            if (destroyTime <= 2)
            {
                gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            }
            if (destroyTime <= 0)
            {
                gameObject.GetComponent<Animator>().SetBool("Destroy", false);
                gameObject.GetComponent<Animator>().StopPlayback();
                gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        destroy = true;
    }
}
