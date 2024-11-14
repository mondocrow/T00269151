using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runningSpeed = 3f;
    float turningSpeed = 45f;
    int coinsCollected = 0;
    Animator EdAnimations;


    // Start is called before the first frame update
    void Start()
    {
        EdAnimations = GetComponent<Animator>();
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runningSpeed*transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= runningSpeed*transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, - turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= runningSpeed * transform.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += runningSpeed * transform.right * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        CoinScript coin = collision.gameObject.GetComponent<CoinScript>();
        if (coin != null)
        {
            coin.Collect();
            coinsCollected += 1;
            if (coinsCollected > 2) 
            {
                EdAnimations.SetBool("Victory", true);
            }
        }
    }
}
