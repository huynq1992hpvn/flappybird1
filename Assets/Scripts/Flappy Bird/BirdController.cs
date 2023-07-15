using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigid2d;
    public float JumpForce;
    public float JumpAngle;
    public float angleRotateSpeed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        rigid2d.gravityScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isEndGame) return;

        bool isTap = Input.GetKeyDown(KeyCode.Space);
        if (isTap)
        {


            Jump();

        }
        if (GameManager.Instance.isStartGame == false) return;
        RotateBird();
    }
    public void StartGame()
    {
        rigid2d.gravityScale = 1;
    }

    protected void Jump()
    {
        rigid2d.velocity = Vector2.up * JumpForce;
        transform.eulerAngles = new Vector3(0, 0, JumpAngle);
        AudioManager.Instance.PlayFlapBird();
    }
    public void Dead()
    {
        animator.enabled = false;
    }
    protected void RotateBird()
    {
        transform.eulerAngles -= new Vector3(0, 0, angleRotateSpeed * Time.deltaTime);
        //if(transform.eulerAngles.z <= -50f)
        //{
        //    transform.eulerAngles = new Vector3(0, 0, -50f);
        //}
    }
}
