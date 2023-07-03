using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int direction;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(direction * Time.deltaTime * speed, 0, 0);
    }
}
