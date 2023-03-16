using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TakeDMG : MonoBehaviour
{
    public int health;
    Animator anim;
    [SerializeField] private Text HealthText;
    [SerializeField] private ZombieAttack death;
    private void Start() 
    {
        health=11;
        HealthText.text= "Health: "+health;
        anim=GetComponent<Animator>(); 
    }
    public void LoseHealth(int dmg)
    {
        health=health-dmg;
        HealthText.text="Health: "+health;
        anim.Play("PlayerHit");
        if(health<=0)
        {
            death.Die();
        }
        
        
    }
}
