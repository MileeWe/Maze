using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow)) rb.velocity += Vector2.left * speed;
        if (Input.GetKey(KeyCode.RightArrow)) rb.velocity += Vector2.right * speed;
        if (Input.GetKey(KeyCode.UpArrow)) rb.velocity += Vector2.up * speed;
        if (Input.GetKey(KeyCode.DownArrow)) rb.velocity += Vector2.down * speed;
    }
}
