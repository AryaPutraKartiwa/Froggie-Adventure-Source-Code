using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Obstacles;
    public float x1;
    public float x2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacles = Instantiate(Obstacles);
        newObstacles.transform.position = transform.position + new Vector3(Random.Range(x1,x2),0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
       if(timer>maxTime)
       {
           GameObject newObstacles = Instantiate(Obstacles);
           newObstacles.transform.position = transform.position + new Vector3(Random.Range(x1,x2),0,0);
           Destroy(newObstacles,15);
           timer = 0;
       }
        
        timer += Time.deltaTime;
    }
}
