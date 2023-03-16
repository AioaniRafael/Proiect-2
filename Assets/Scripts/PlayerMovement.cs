using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sprite;
    [SerializeField] public float MovementSpeed=7;

    private float dirX,dirY;
    private enum MovementState{idle,run,hit};
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sprite=GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        dirX=Input.GetAxisRaw("Horizontal");
        dirY=Input.GetAxisRaw("Vertical");
        rb.velocity=new Vector2(dirX*MovementSpeed,dirY*MovementSpeed);
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        MovementState state;
        if(dirX>.0)
        {
            state=MovementState.run; 
            sprite.flipX=false;
        }
        else if(dirX<.0)
        {
            state=MovementState.run;
            sprite.flipX=true;
        }
        else if(dirY>.0) {
            state=MovementState.run; 
            
        }
        else if(dirY<.0) {
            state=MovementState.run;
            
        }
        else
        {
            state=MovementState.idle;
        }   
        anim.SetInteger("state",(int)state);
    }


    private void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
