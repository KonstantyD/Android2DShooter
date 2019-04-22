using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    int licznik = 0;
    int i = 0;
    int j = 0;
    public Transform spawnPoint;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public GameObject enemyPrefab;
    public GameObject pointPrefab;
    public Transform PointSpawnPoint;
    public Transform PointSpawnPoint1;
    public Transform PointSpawnPoint2;
    public Transform PointSpawnPoint3;
    public Transform PointSpawnPoint4;
    public Transform PointSpawnPoint5;
    public static int Enemycnt;
    public static int Enemykilled;
    public static int pktzawrogow=0;
    static System.Random rnd = new System.Random();
    int k = rnd.Next(4);
    static System.Random rnd1 = new System.Random();
    int p = rnd.Next(4);
    // Update is called once per frame
    void FixedUpdate()
    {
        if (licznik == 300)
        {
            PointSpawn();
        }
        if (licznik == 500)
        {
            Spawn();
            licznik = 0;
        }
        licznik++;

        if (pktzawrogow % 5 == 4)
        {
            Playerdmg.score++;
            pktzawrogow = 0;
        }
        
    }

    void PointSpawn()
    {
        if (j == 0 )
        {
            Instantiate(pointPrefab, PointSpawnPoint.position, PointSpawnPoint.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
        else if (j == 1 )
        {
            Instantiate(pointPrefab, PointSpawnPoint1.position, PointSpawnPoint1.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
        else if (j == 2 )
        {
            Instantiate(pointPrefab, PointSpawnPoint2.position, PointSpawnPoint2.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
        else if (j == 3 )
        {
            Instantiate(pointPrefab, PointSpawnPoint3.position, PointSpawnPoint3.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
        else if (j == 4 )
        {
            Instantiate(pointPrefab, PointSpawnPoint4.position, PointSpawnPoint4.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
        else if (j == 5 )
        {
            Instantiate(pointPrefab, PointSpawnPoint5.position, PointSpawnPoint5.rotation);
            //j++;
            j = p;
            p = rnd1.Next(6);
        }
    }

    void Spawn()
    {
        if (i == 0&&Enemycnt<4)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            //i++;
            i = k;
            k = rnd.Next(4);
        }
        else if (i == 1 && Enemycnt < 4)
        {
            Instantiate(enemyPrefab, spawnPoint1.position, spawnPoint1.rotation);
            //i++;
            i = k;
            k = rnd.Next(4);
        }
        else if (i == 2 && Enemycnt < 4)
        {
            Instantiate(enemyPrefab, spawnPoint2.position, spawnPoint2.rotation);
            //i++;
            i = k;
            k = rnd.Next(4);
        }
        else if (i == 3 && Enemycnt < 4)
        {
            Instantiate(enemyPrefab, spawnPoint3.position, spawnPoint3.rotation);
            //i = 0;
            i = k;
            k = rnd.Next(4);
        }
    }
}
