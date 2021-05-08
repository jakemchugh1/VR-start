using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    
    public Transform origin;

    private double startTime;

    void Start()
    {
        origin = transform;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > startTime + 2)
        {
            Instantiate(gameObject, origin);
        }
    }
}
