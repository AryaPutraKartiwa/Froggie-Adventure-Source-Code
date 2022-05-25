using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        Score.score++;
      
    }
}
