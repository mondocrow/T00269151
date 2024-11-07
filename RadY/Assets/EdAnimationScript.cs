using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EdAnimationScript : MonoBehaviour
{
    Animator edAnimator;
    float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edAnimator.SetBool("IsWalking", false);
        edAnimator.SetBool("IsRunning", false);
        edAnimator.SetBool("BackwardsWalk", false);
        edAnimator.SetBool("BackwardsRun", false);

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                edAnimator.SetBool("IsRunning", true);
                speed = 1.5f;
            }
            else
            {
                // make ed walk in animations and move forward
                edAnimator.SetBool("IsWalking", true);
                speed = 1;
            }
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        {
            if (Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    edAnimator.SetBool("BackwardsRun", true);
                    speed = 1.5f;
                }
                else
                {
                    edAnimator.SetBool("BackwardsWalk", true);
                    speed = 1;
                }
                transform.position += speed * -transform.forward * Time.deltaTime;
            }
        }
    }   
}  
