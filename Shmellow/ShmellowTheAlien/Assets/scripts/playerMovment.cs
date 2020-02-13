using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D Rb;
    public bool isGrounded = false;
    



    private void Update()
    {
        Jump();
        Move();

    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
        }
    }

    public void Crouch()
    {
        if(Input.GetButton("Crouch") && isGrounded == true)
        {
          
        }
    }

    public void Move()
    {
            
            Vector3 movment = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            transform.position += movment * Time.deltaTime * speed;
    }
  

}
