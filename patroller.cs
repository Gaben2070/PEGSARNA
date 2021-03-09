using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattroler : MonoBehaviour
{
  public Transform[] waypoints;
  public int speed;

  private int waypointIndex;
  private float dist;

    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < 1f)
        {
          IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
       transform.Translate(vector3.forward * speed * Time.deltaTime);

    }

    void IncreaseIndex()
    {
      waypointIndex++;
      if(waypointIndex >= waypoints.Length)
      {
        waypointIndex = 0;
      }
      transform.LookAt(waypoints[waypointIndex].position);
    }
}
