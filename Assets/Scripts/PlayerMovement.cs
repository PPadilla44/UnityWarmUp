using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int speed;
    public Transform cam;

    private float facing;
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {

        Vector3 movement = new Vector3((Input.GetAxis("Horizontal") * speed), 0, (Input.GetAxis("Vertical") * speed));
        movement = cam.TransformDirection(movement);
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        if(movement.x != 0 && movement.z != 0)
        {
            facing = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
        }
        rb.rotation = Quaternion.Euler(0, facing, 0);
    }

    private void FixedUpdate()
    {
        cam.eulerAngles = new Vector3(0, cam.eulerAngles.y, cam.eulerAngles.z);
    }
}
