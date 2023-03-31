using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     GameObject gm;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        swarm();
    }
    private void swarm()
    {
        transform.position=Vector2.MoveTowards(transform.position,gm.transform.position,speed*Time.deltaTime);
    }
}
