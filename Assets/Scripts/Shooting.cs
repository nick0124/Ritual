using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public Animator anim;
    public float bulletSpeed;
    public float bulletLifetime;

    public float reloadTime;
    public float reloadTimer;

    public bool bulletChildOfGun;
    public bool shoot;

    // Use this for initialization
    void Start()
    {
        reloadTimer = reloadTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = transform.right;

        if (reloadTimer > 0)
            reloadTimer -= Time.deltaTime;
        //анимация начинает проигрыватся за 1 сек до выстрела
        if(reloadTimer<1)
        {
            anim.SetBool("Shoot",true);
        }

        if (shoot && reloadTimer < 0)
        {
            //после выстрела перестает проигрыватся
            anim.SetBool("Shoot", false);

            reloadTimer = reloadTime;

            GameObject bulletInstance = (GameObject)Instantiate(bulletPrefab, spawnPoint.position, transform.rotation);
            Destroy(bulletInstance, bulletLifetime);
            if (bulletChildOfGun)
                bulletInstance.transform.parent = gameObject.transform;
            bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction.x, bulletSpeed * direction.y);
        }
    }
}
