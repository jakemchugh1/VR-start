using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    private double startTime;
    public Object ball;
    public Transform spawn;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > startTime + 2)
        {
            Instantiate(ball, spawn.transform.position,spawn.rotation,spawn);
            startTime = Time.time;
        }
    }
}
