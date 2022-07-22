using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 velocity;
    public Rigidbody2D rb2D;
    public float speed = 2.0f;

    void FixedUpdate()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2D.MovePosition(rb2D.position + velocity* speed * Time.fixedDeltaTime);
    }
}
