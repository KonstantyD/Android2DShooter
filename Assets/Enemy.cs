using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;
    float horizontalMove = 0f;
    public float runSpeed = 40f;

    public CharacterController2D controller;
    public GameObject deathEffect;
    public Animator animator;
    //public Rigidbody2D rb;

    public Transform firePoint;
    public GameObject bulletPrefab;
    //public Transform PlayerPos;
    public Transform EnemyPos;
    bool OnLand = false;

    GameObject Player;
    Transform houseTransform;

    int licznikshoot=0;
    int licznikidz = 0;
    bool ziemia = false;
    float initx = 0;


    void Start()
    {
        transform.Rotate(0f, 180f, 0f);
        initx = EnemyPos.position.x;
        //Player = Transform.FindWithTag("Player");
        Player = GameObject.FindWithTag("Player");
        houseTransform = Player.GetComponent<Transform>();
        EnemySpawn.Enemycnt++;
    }

   


    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        EnemySpawn.Enemycnt--;
        EnemySpawn.Enemykilled++;
        EnemySpawn.pktzawrogow++;
        Destroy(gameObject);
    }

    
    



    // Update is called once per frame
    void Update()
    {
        
        



    }

    private void FixedUpdate()
    {
        if (licznikshoot == 50 || licznikshoot == 60 || licznikshoot == 70)
        {
            Shoot();
            if (licznikshoot == 70)
            {
                licznikshoot = 0;
            }
        }
        if (licznikidz > 100)
        {
            Move();
            if (licznikidz == 150)
            {
                licznikidz = 0;
                horizontalMove = 0f;
                animator.SetBool("Run", false);
            }
        }
        licznikshoot++;
        licznikidz++;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void Move()
    {

        //animator.SetBool("Run", true);
        if (houseTransform.position.x > EnemyPos.position.x && EnemyPos.position.x < initx + 2)
        {
            animator.SetBool("Run", true);
            horizontalMove = runSpeed;
        }
        else if (houseTransform.position.x <= EnemyPos.position.x && EnemyPos.position.x > initx - 2)
        {
            animator.SetBool("Run", true);
            horizontalMove = (-1) * runSpeed;
        }




        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);

        
        
    }

}
