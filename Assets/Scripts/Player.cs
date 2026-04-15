using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Player : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float jumpHeight = 5f;
    public bool isGround = true;
    private float movement;
    public float moveSpeed = 5f;
    private bool facingRignt = true;
    void Start()
    {

    }
    void Update()
    {

        movement = Input.GetAxis("Horizontal");
        if (movement < 0f && facingRignt)
        {
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
            facingRignt = false;
        }
        else if (movement > 0 && facingRignt == false)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            facingRignt = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && isGround)
        {
            Jump();
            isGround = false;
            animator.SetBool("Jump", true);
        }
        if (Mathf.Abs(movement) > 0f)
        {
            animator.SetFloat("Run", 1f);
        }
        else if (movement < .1f)
        {
            animator.SetFloat("Run", 0f);
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(movement, 0f, 0f) * Time.fixedDeltaTime * moveSpeed;
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            animator.SetBool("Jump", false);
        }
    }
    void Die()
    {
        Debug.Log("Player Die");
    }
}
