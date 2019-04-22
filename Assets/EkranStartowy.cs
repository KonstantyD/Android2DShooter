using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EkranStartowy : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Playerdmg.health = 500;
        Playerdmg.score = 0;
        EnemySpawn.Enemykilled = 0;
        EnemySpawn.Enemycnt = 0;
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
