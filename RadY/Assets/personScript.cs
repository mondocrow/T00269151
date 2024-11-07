using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personScript : MonoBehaviour
{
    int health = 100;
    int damage = 15;
    Rigidbody rb;
    internal void explosionAt(Vector3 position, float explosionRadius, float explosionStrength)
    {
        health -= damage;
        print("Ouch my health is now " + health.ToString());
        rb.AddExplosionForce(explosionStrength, position, explosionRadius);
    
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
