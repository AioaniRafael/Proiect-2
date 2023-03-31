using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float AttackDMG;
    [SerializeField] Animator anim;
    [SerializeField] Animator animSkely;
    
    //[SerializeField]
    private GameObject gm;
    
    private int skelyHealth=10;
    private int playerDMG=10;
    private void Start() {
    //gm=GetComponent<GameObject>();
        
    }
    void Update()
    {
        gm=GameObject.FindGameObjectWithTag("Skeleton");
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetBool("IsHit",true);
           
            if(Vector2.Distance(gm.transform.position,transform.position)<3f)
            {
                skelyHealth=skelyHealth-playerDMG;
                if(skelyHealth<=0f)
                {
                    animSkely.SetBool("Die",true);
                    

                }
            }
        }
        else if(Input.GetMouseButtonUp(0))
        {
            anim.SetBool("IsHit",false);
        }
        
    }
    
}
