using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidbody2d;
    private GatherInput gatherInput;
    private int enemyLayer;

    void Start()
    {
        enemyLayer = LayerMask.NameToLayer("Enemy");
        rigidbody2d = GetComponent<Rigidbody2D>();
        gatherInput = GetComponent<GatherInput>();
    }

    void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(speed * gatherInput.directionX, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == enemyLayer)
        {
            speed = 0;
        }
    }
}