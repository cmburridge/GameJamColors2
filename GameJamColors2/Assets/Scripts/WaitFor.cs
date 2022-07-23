using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WaitFor : MonoBehaviour
{
    public UnityEvent time;

    private void Start()
    {
        StartCoroutine(TimesUp());
    }

    public IEnumerator TimesUp()
    {
        yield return new WaitForSeconds(2);
        time.Invoke();
    }
}
