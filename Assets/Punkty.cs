using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkty : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Playerdmg player = hitInfo.GetComponent<Playerdmg>();
        if (player != null)
        {
            player.Punkty();
        }


        Destroy(gameObject);
    }
}
