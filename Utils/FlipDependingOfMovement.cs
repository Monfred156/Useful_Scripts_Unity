using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipDependingOfMovement : MonoBehaviour
{
    [SerializeField]
    private bool facingRight = true;
    
    private Vector3 previousPosition;

    void Start()
    {
        previousPosition = new Vector3();
    }

    void Update()
    {
        Vector3 currentDirection = (transform.position-previousPosition).normalized;
        previousPosition = transform.position;
        if (currentDirection.x < 0 && facingRight)
        {
            Flip();
        } else if (currentDirection.x > 0 && !facingRight)
        {
            Flip();
        }
    }
    
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}