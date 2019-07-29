using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordMove : MonoBehaviour
{
    public float Speed = 3;

    private void Update()
    {
        if(transform.position.x<= -20)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            
        }
    }   
}
