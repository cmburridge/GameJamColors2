using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Destroy : MonoBehaviour
{
    public GameObject[] prefabs = {};
    public bool isBits = false;
    
    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }

    public void SpawnBits()
    {
        var bit = prefabs[Random.Range(0, prefabs.Length)];
        Instantiate(bit, this.transform.position, quaternion.identity);
    }

    private void Update()
    {
        if (isBits == true)
        {
            StartCoroutine(DestroyTimer());
        }
    }

    private IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
