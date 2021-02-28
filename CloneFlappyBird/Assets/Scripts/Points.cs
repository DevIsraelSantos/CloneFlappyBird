using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    public gameControle controle;

    private void Start()
    {
        controle = FindObjectOfType<gameControle>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controle.score++;
        controle.TxtScore.text = controle.score.ToString();
    }

}
