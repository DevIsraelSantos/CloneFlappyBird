using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{

    public GameObject pipe;
    public float height = 2;
    public float maxTime = 3;

    float timer = 0f;
    
    void Start()
    {
        novoPipe();
    }

    void Update()
    {
        if(timer > maxTime)
        {
            novoPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void novoPipe()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 5f);
    }
}
