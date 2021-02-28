using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rig;
    public GameObject gameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;

        }
    }

    private void OnCollisionEnter2D(Collision2D colisor)
    {
        //chame gameOver
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
