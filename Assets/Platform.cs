using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D other) {
        Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
        if (rb == null) return;

        Vector2 velocity = rb.velocity;
        velocity.y = jumpForce;
        rb.velocity = velocity;
    }
}
