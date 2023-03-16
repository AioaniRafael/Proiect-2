using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieAttack : MonoBehaviour
{
    float CurentTime=0f;
    float StartingTime=5f;
    float WaitTime=0f;
    private Animator anim1;
    private Rigidbody2D rb1; 
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb; 
    [SerializeField] private float minDistance;
    [SerializeField] private GameObject gm;
    [SerializeField] private GameObject gm1;
    [SerializeField] private TakeDMG dmg;
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
            WaitTime+=1*Time.deltaTime;
            
            if(CurentTime<0f)
            { 
                if(WaitTime>5f)
                {
                    anim1.SetTrigger("attck");
                    dmg.LoseHealth(10);
                    WaitTime=0;
                    anim1.SetTrigger("move");
                }
                    
                
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
    public void Die()
    {
        
        
        anim.SetTrigger("death");
        
    }
    private void destroy()
    {
        Destroy(gm1);
    }
    
}
