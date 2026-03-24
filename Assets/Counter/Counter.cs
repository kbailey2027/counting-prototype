using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    public float force = 5f;

    public List<GameObject> spheres = new List<GameObject>();

    private Rigidbody rb;

    public void Start()
    {
        Count = 0;
    }

    public void Update()
    {
       if (Count >= 10)
        {
            foreach (GameObject sphere in spheres)
            {
                Rigidbody rb = sphere.GetComponent<Rigidbody>();
                rb.AddForce(Vector3.up * force);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }

    private void OnTriggerExit(Collider other)
    {
        Count -= 1;
        CounterText.text = "Count : " + Count;
    }
}
