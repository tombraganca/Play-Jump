using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D rig;
    private bool isJumping;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);

        if (Input.GetMouseButtonDown(0) && !isJumping)
        {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {

        if (collider.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }
}
