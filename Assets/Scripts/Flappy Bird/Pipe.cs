using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()

    {
        if (GameManager.Instance.isEndGame)  return; 
        this.transform.position += Vector3.left * GameManager.Instance.speed *Time.deltaTime; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy") 
        {
            Destroy(gameObject);
        }
    }
}
