using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControle : MonoBehaviour
{

    public int score;
    public Text TxtScore;


    private void Start()
    {
        Time.timeScale = 1;
        score = 0;
    }
    public void restartGame()
    {
        
        SceneManager.LoadScene(0);
    }

}
