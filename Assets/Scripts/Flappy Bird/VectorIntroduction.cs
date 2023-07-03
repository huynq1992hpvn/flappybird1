using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorIntroduction : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {

        Vector2 VectorA = new Vector2(0, 1);
        Vector3 VectorB = new Vector3(0, 1, 0);
        Debug.Log(VectorA);
        Debug.Log(VectorB);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move(Vector3 steps)
    {
        this.transform.position += steps * speed *Time.deltaTime;
    }
}
