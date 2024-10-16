using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1, 0)* Time.deltaTime;

    }
}
