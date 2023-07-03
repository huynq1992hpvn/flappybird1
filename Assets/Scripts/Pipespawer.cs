using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawer : MonoBehaviour
{
    public GameObject pipeCopy;
    public Transform spawnPosition;
    public float delayPerSpawn;
    private float currentTimeSpawn =0;
    public Vector2 offsetPipeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (GameManager.Instance.isStartGame == false) return;
        if (GameManager.Instance.isEndGame) return;
        if (currentTimeSpawn > delayPerSpawn)
        {
            currentTimeSpawn = 0;
            SpawnPipe();
        }
        currentTimeSpawn += Time.deltaTime;


    }
    public void SpawnPipe()
    {
        GameObject pipe = Instantiate(pipeCopy);
        pipe.transform.position = spawnPosition.position;
        var offset = Random.Range(offsetPipeSpawn.x, offsetPipeSpawn.y);
        pipe.transform.position += new Vector3(0, offset);
    }

}
