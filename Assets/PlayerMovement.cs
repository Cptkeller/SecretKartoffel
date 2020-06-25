using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    Vector2 movement;
    public Camera cam;
    Vector2 mousePos;
    private bool isMoving = false;
    Vector3 TargetPosition;


  


    

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            SetTargetPosition();
        }
        if (isMoving){
            move();
        }




  }
    void SetTargetPosition(
        )
    {
        TargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TargetPosition.z = transform.position.z;

        isMoving = true;

    }

    void FixedUpdate()
    {

       rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void move()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, TargetPosition);
  
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, moveSpeed * Time.deltaTime);
        if (transform.position == TargetPosition)
        {
            isMoving = false;
        }
    
    }

}
