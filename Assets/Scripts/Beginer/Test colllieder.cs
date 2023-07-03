using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testcolllieder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " strarts collide with" + collision.gameObject.name);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
         
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
