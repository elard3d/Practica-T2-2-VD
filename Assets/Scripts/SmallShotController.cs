using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SmallShotController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocityX = 10f;
    private Rigidbody2D _rigidbody;

    private int contador = 0;
    
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
        Destroy(this.gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = Vector2.right * velocityX;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" )
        {
             //Destroy(collision.gameObject);

             contador++;
             
            Debug.Log(contador);
        }
    }
    
}
