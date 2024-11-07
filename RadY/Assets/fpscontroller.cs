using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpscontroller : MonoBehaviour
{
    public GameObject capsuleCloneTemplate;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()

    {    if (Input.GetKey(KeyCode.W))
        {   Vector3 fpsMovementDirection = new Vector3(transform.forward.x, 0, transform.forward.z);
    fpsMovementDirection.Normalize();
            transform.position += speed* fpsMovementDirection * Time.deltaTime;

        }
if (Input.GetKey(KeyCode.S))
{
    Vector3 fpsMovementDirection = new Vector3(transform.forward.x, 0, transform.forward.z);
    fpsMovementDirection.Normalize();
    transform.position -= speed * fpsMovementDirection * Time.deltaTime;

}
if (Input.GetKey(KeyCode.D))
{
    Vector3 fpsMovementDirection = new Vector3(transform.right.x, 0, transform.forward.z);
    fpsMovementDirection.Normalize();
    transform.position += speed * fpsMovementDirection * Time.deltaTime;

}
if (Input.GetKey(KeyCode.A))
{
    Vector3 fpsMovementDirection = new Vector3(transform.right.x, 0, transform.forward.z);
    fpsMovementDirection.Normalize();
    transform.position -= speed * fpsMovementDirection * Time.deltaTime;

}
transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

if (Input.GetMouseButtonDown(0))
{
    Instantiate(capsuleCloneTemplate, transform.position, transform.rotation);


}


    }
}
