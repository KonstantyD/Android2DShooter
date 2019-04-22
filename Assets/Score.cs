using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Enemies Killed:" +EnemySpawn.Enemykilled.ToString()+Environment.NewLine+"Health:"+Playerdmg.health.ToString()+Environment.NewLine+"Score: "+Playerdmg.score.ToString();
    }
}
