using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        
        Destroy(this.gameObject, 15);
        
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(-2,_rigidbody.velocity.y);
    }
}
