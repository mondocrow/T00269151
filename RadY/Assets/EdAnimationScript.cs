using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EdAnimationScript : MonoBehaviour
{
    Animator EdAnimations;
    float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        EdAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        EdAnimations.SetBool("IsWalking", false);
        EdAnimations.SetBool("IsRunning", false);

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                EdAnimations.SetBool("IsRunning", true);
                speed = 1.5f;
            }
            else
            {
                // make ed walk in animations and move forward
                EdAnimations.SetBool("IsWalking", true);
                speed = 1;
            }
            transform.position += speed * transform.forward * Time.deltaTime;
        }
    }   
}  
