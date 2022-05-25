using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFroggie : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
        else if(other.gameObject.CompareTag("Coin"))
        {
            Score.score++;
            Destroy(other.gameObject);
        }
       
    }
    

}
