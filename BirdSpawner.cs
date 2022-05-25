using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Obstacles;
    public float height;
    public float groundLimit;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacles = Instantiate(Obstacles);
        newObstacles.transform.position = transform.position + new Vector3(0, Random.Range(groundLimit,height),0);
        
    }

    // Update is called once per frame
    void Update()
    {
       if(timer>maxTime)
       {
           GameObject newObstacles = Instantiate(Obstacles);
           newObstacles.transform.position = transform.position + new Vector3(0, Random.Range(groundLimit,height),0);
           Destroy(newObstacles,15);
           timer = 0;
       }
        
        timer += Time.deltaTime;
    }
}
