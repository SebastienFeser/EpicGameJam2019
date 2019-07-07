using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovements : MonoBehaviour
{

    private Rigidbody2D body2D;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    private bool m_FacingRight = true;

    private float targetTime = 5.0f;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
        if (gameObject.tag == "human")
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }

    void FixedUpdate()
    {
        Move(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime);
    }

    public void Move(float moveX, float moveY)
    {
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(moveX * 10f, moveY * 10f);
        body2D.velocity = targetVelocity;
        // If the input is moving the player right and the player is facing left...
        if (moveX > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (moveX < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void timerEnded()
    {
        Destroy(gameObject);
    }
}
