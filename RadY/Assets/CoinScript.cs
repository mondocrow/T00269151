using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    float turningSpeed = 45f;

    internal void Collect()
    {
        print("Ive been COllected");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, + turningSpeed * Time.deltaTime);

    }
}
