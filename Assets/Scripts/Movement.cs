using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] PlayerTypes type;
    [SerializeField] float speedMultiplier;

    enum PlayerTypes
    {
        FARMER,
        BUNNY,
        FOX,
        CHICKEN
    }
    

    private void Update()
    {
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speedMultiplier, Input.GetAxisRaw("Vertical") * speedMultiplier);
    }

    private void FixedUpdate()
    {
        
    }


}
