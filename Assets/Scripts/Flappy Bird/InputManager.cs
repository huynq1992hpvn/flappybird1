using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.Timeline;

public class InputManager : MonoBehaviour
{
    public VectorIntroduction objectneedmove;
    public KeyCode key = KeyCode.A;
    public int Mou=0;
    public float timeRest;
    public SpriteRenderer spriteRender;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is InputManager run on Start()");
        objectneedmove = GetComponent<VectorIntroduction>();
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Xu ly phat hien input cua nguoi dung
        //class input se chiu trach nhiem doc input cua nguoi dung
        //Read Input from Mouse
        PhimA();
        chuottrai();
        dieuhuong();
        



    }
    protected void PhimA()
    {
        
        bool startPressKey = Input.GetKeyDown(key);
        bool holdPressKey = Input.GetKey(key);
        bool releasePressKey = Input.GetKeyUp(key);
        if (startPressKey == true)
        {
            Debug.Log("Bat dau bam phim" );

        }
        if (holdPressKey == true)
        {
            Debug.Log("Dang giu phim A");
        }
        if (releasePressKey == true)
        {
            Debug.Log("Nha phim A");
        }
        
    }
    protected void chuottrai()
    {
        bool startClick = Input.GetMouseButtonDown(Mou);
        bool holdClick = Input.GetMouseButton(Mou);
        bool releaseClick = Input.GetMouseButtonUp(Mou);
        if (startClick == true)
        {
            
            Debug.Log("Bat dau click chuot");

        }
        if (holdClick == true)
        {
            Debug.Log("Dang giu chuot");
        }
        if (releaseClick == true)
        {
            Debug.Log("Da nha chuot");
        }
    }
    protected void dieuhuong() { 

        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float VerticalAxis = Input.GetAxisRaw("Vertical");
        objectneedmove.Move(new Vector3 (horizontalAxis, VerticalAxis, 0));
    }
    
}
