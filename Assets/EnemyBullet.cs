using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public Transform BulletPoint;
    //public Transform PlayerPos;

    GameObject Player;
    Transform houseTransform;
    Vector3 Norm;
    double dlugosc=0;

    bool jeb = false;
    // Use this for initialization
    void Start()
    {
        //rb.velocity = transform.right* speed;

        Player = GameObject.FindWithTag("Player");
        houseTransform = Player.GetComponent<Transform>();
        dlugosc = System.Math.Sqrt((houseTransform.position.x)* (houseTransform.position.x)+ (houseTransform.position.y) * (houseTransform.position.y));

        float d = (float)dlugosc;
        if (float.IsPositiveInfinity(d))
        {
            d = float.MaxValue;
        }
        else if (float.IsNegativeInfinity(d))
        {
            d = float.MinValue;
        }

        float x = (float)houseTransform.position.x;
        if (float.IsPositiveInfinity(x))
        {
            x = float.MaxValue;
        }
        else if (float.IsNegativeInfinity(x))
        {
            x = float.MinValue;
        }
        Norm.x = (x - BulletPoint.position.x) / d;

        float y = (float)houseTransform.position.y;
        if (float.IsPositiveInfinity(y))
        {
            y = float.MaxValue;
        }
        else if (float.IsNegativeInfinity(y))
        {
            y = float.MinValue;
        }
        Norm.y = (y -BulletPoint.position.y)/ d;

        rb.velocity = Norm * speed;
    }



    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Playerdmg player = hitInfo.GetComponent<Playerdmg>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        jeb = true;

        //Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        if (jeb)
        {

            Destroy(gameObject);
        }


    }
}
