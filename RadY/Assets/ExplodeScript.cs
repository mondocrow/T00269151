using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    Rigidbody rb;
    float explosionRadius = 30f;
    float explosionStrength = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100 * transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in allVictimColliders)
        {
            personScript personVictim = collider.GetComponent<personScript>();
            if (personVictim != null)
            {
                personVictim.explosionAt(transform.position, explosionRadius, explosionStrength);
            }
            else
            {
                Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
                if (rigidbody != null)
                {
                    rigidbody.AddExplosionForce(explosionStrength, transform.position, explosionRadius);
                }
            }

            Destroy(gameObject);
        }

    }
}
