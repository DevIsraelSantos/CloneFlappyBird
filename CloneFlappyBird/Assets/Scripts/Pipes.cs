﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;    
    }
}