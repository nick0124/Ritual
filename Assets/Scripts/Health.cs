using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public Text healthUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (healthUI != null)
            healthUI.text = health.ToString();
	}

    void FixedUpdate()
    {
        if (health <= 0)
        {
            if(gameObject.name=="Player")
            {
                gameObject.GetComponent<Animator>().Play("Death");
            }
        }
            //Debug.Log(gameObject.name + " Death");
        //проигрывание анимации смерти, и уничтожение или проигрыш
    }

    public void EndGame()
    {
        //Debug.Log("Defeat");
        Application.LoadLevel("Menu");
    }
}
