using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxCollision : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "rabbit" || collision.tag == "chicken")
        {
            Destroy(collision.gameObject);
        }
    }
}
