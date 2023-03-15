using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieAttack : MonoBehaviour
{
    float CurentTime=0f;
    float StartingTime=5f;
    private Animator anim1;
    private Rigidbody2D rb1; 
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb; 
    [SerializeField] private float minDistance;
    [SerializeField] private GameObject gm;
    //[SerializeField] private Collider2D collision;
    void Start()
    {
        CurentTime=StartingTime;
        anim1=GetComponent<Animator>();
        rb1=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
         if(Vector2.Distance(gm.transform.position,transform.position)<minDistance)
         {
            CurentTime-=1*Time.deltaTime;
           
            
            if(CurentTime<0f)
            { 
                
                anim1.SetTrigger("attck");
                Die();
            }
            
         }
         else
         {
            CurentTime=StartingTime;
         }
            
        
    }
    
    

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player"))
        {
            CurentTime=StartingTime;
        } 
    }
    private void Die()
    {
        
        rb.bodyType=RigidbodyType2D.Static;
        anim.SetTrigger("death");
        
    }
    
}
