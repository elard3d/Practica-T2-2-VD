using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    public GameObject smallShot;
    public GameObject enemy;

    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            setRunShotingAnimation();
            Instantiate(smallShot, transform.position, smallShot.transform.rotation);
        }

        
        
        _rigidbody.velocity = new Vector2(0,_rigidbody.velocity.y);
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _renderer.flipX= false;
            setRunAnimation();
            _rigidbody.velocity = new Vector2(2,_rigidbody.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _renderer.flipX = true;
            setRunAnimation();
            _rigidbody.velocity = new Vector2(-2,_rigidbody.velocity.y);
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.UpArrow)  || Input.GetKeyDown(KeyCode.Space) )
        {
            var upSpeed = 15f;
            _rigidbody.velocity = Vector2.up * upSpeed;

            setJumpAnimation();
            
        }

        // if (murio == 1)
        // {
        //     setDeadAnimation();
        // }
        
    }

    private void setIdleAnimation(){
        _animator.SetInteger("Estado",0);
    }
    
    private void setRunAnimation(){
        _animator.SetInteger("Estado",1);
    }
    
    private void setJumpAnimation(){
        _animator.SetInteger("Estado",2);
    }
    
    private void setRunShotingAnimation(){
        _animator.SetInteger("Estado",3);
    }

}
