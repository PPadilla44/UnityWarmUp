using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public int jumpForce;
    public LayerMask groundLayer;
    public Transform groundCheck;

    private bool canJump;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Jump") && canJump)
        {
            Jump();
        }
        bool grounded = Physics.Linecast(new Vector3(transform.position.x, transform.position.y, transform.position.z), groundCheck.position, groundLayer);

        Debug.DrawLine(new Vector3(transform.position.x, transform.position.y, transform.position.z), groundCheck.position, Color.red);
        
        if(grounded)
        {
            canJump = true;
        } 
        else
        {
            canJump = false;
        }
    }

    private void Jump()
    {
        canJump = false;
        rb.AddForce(Vector3.up * jumpForce);
    }
}
