using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    public GameObject sphere;
    private GameObject s => sphere;

    private void Start()
    {
        Count = 0;
    }

    private void Update()
    {
       if (Count >= 10)
        {
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }
}
