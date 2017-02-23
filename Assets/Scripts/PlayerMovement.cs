using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public Transform groundCheck;
    public float speed = 1000;
    public float jump = 1000;
    public Animator anim;

    public LayerMask whatIsGround;
    public float groundRadius;
    public bool grounded;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if(grounded)
        {
            anim.SetBool("Grounded", true);
        }
        else
        {
            anim.SetBool("Grounded", false);
        }

        if (Input.GetKey("w") && grounded)
        {
            rb.AddForce(Vector2.up * jump);
        }

        //конвертация хп в ходы
        if (Input.GetKeyDown("e"))
        {
            //если не максимум ходов
            if (gameObject.GetComponent<MovePoints>().movePoints < 10)
            {
                //то отнимаем 20 хп и добавляем 1 ход
                gameObject.GetComponent<Health>().health -= 20;
                gameObject.GetComponent<MovePoints>().movePoints += 1;
            }
        }


        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);

            if (grounded)
                anim.SetBool("Run", true);

            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);

            if (grounded)
                anim.SetBool("Run", true);

            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetBool("Run", false);
        }

        if(Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Atack", true);
            //проигрывание анимации атаки, когда проигралась можно нажать еще раз
        }
        else
        {
            anim.SetBool("Atack", false);
        }
    }
}
