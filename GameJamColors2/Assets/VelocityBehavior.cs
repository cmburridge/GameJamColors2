using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class VelocityBehavior : MonoBehaviour
{
    public float speedMax;

    private void Awake()
    {
        float randomZ = Random.Range(0,360);
        this.transform.eulerAngles = new Vector3(0, 0, randomZ);
        float speed = Random.Range(100, speedMax);
        
        Vector3 direction = new Vector3(Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            0);
        direction.Normalize();
        Vector3 newVelocity = speed * direction;
        transform.GetComponent<Rigidbody>().velocity = newVelocity;
    }
}
