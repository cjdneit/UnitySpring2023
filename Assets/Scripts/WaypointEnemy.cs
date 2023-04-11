using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnemy : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    Vector3 targetPos;
    [SerializeField]
    [Range(0, 1)]
    float movespeed = 0;
    int waypointIndex;


    // Start is called before the first frame update
    void Start()
    {
        targetPos = waypoints[0].position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.5f * movespeed);

        if(Vector3.Distance(transform.position, targetPos)<0.3f)
        {
            if(waypointIndex >= waypoints.Length    - 1)
            {
                waypointIndex = 0;
            }
            else
            {
                waypointIndex++;
            }
            targetPos = waypoints[waypointIndex].position;
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().takeDamage(10.0f);
        }
    }

}
