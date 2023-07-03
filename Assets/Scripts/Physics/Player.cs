using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRb;
    public float speed;
    public float jumpforce;
    public bool isOnGround;
    private void Update()
    {
        // xu ly input
        // di chuyen nhan vat bang 2 phim mui ten
        Movement();
        Jump();
    }
    protected void Movement()
    {
        //Get Input "Horionztal"
        float dichuyenTraiPhai = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(dichuyenTraiPhai * Time.deltaTime * speed, 0, 0);
        myRb.velocity = new Vector2(dichuyenTraiPhai * speed, myRb.velocity.y);
    }
    protected void Jump()
    {
        if (isOnGround)// neu nhan vat dang dung tren nen dat moi duoc nhay
        {

            bool isJumpInput = Input.GetKeyDown(KeyCode.Space);
            if (isJumpInput)
            {
                myRb.velocity += new Vector2(0, jumpforce);
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        string tagObject = collision.gameObject.tag;
        if (string.Equals(tagObject,"Ground"))
        {
            isOnGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        string tagObject = collision.gameObject.tag;
        if (string.Equals(tagObject, "Ground"))
        {
            isOnGround = false;
        }
    }
}