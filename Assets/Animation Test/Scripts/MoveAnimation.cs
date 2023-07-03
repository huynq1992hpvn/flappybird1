using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public float speedMove;
    public bool isMoving;
    public Animator animator;
    public Rigidbody2D myRb;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        myRb=GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement * speedMove * Time.deltaTime, 0, 0);
        if (movement == 0)
        {
            isMoving = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("Jump", true);
                myRb.velocity += new Vector2(0, jumpforce);
            }
        }
        else
        {
            isMoving = true;
        }
        if (movement >0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (movement <0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        animator.SetBool("Move", isMoving);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Jump", false);
    }
}
