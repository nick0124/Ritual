using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed;
    public Transform groundCheck;
    public Transform wallCheck;
    public LayerMask whatIsGround;
    public Transform pos1;
    public Transform pos2;
    public bool ground;
    public bool wall;
    public float radius;
    public bool attack;

    float moveDir = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ground = Physics2D.OverlapCircle(groundCheck.position, radius, whatIsGround);
        wall = Physics2D.OverlapCircle(wallCheck.position, radius, whatIsGround);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);


        if(hit.collider.gameObject.name=="Player")
        {
            attack = true;
        }
        else
        {
            attack = false;
        }

        //если стена или нет земли то разворачиваемся
        if(wall||!ground)
        {
            moveDir = -moveDir;
        }

        transform.localScale = new Vector2(moveDir, transform.localScale.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * speed, GetComponent<Rigidbody2D>().velocity.y);
	}
}
