using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SmallShotController : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocityX = 10f;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = Vector2.right * velocityX;
    }
}
