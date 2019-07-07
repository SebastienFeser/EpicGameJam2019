using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanCollision : MonoBehaviour
{
    private Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "fox" || collision.tag == "rabbit")
        {
            Destroy(collision.gameObject);
        }
    }

}
