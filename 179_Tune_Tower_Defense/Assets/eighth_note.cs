using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eighth_note : MonoBehaviour
{
   public float speed = 10f;
   public int health = 100;

   private Transform target;
   private int waypointIndex = 0;

   private bool isDead = false;

   void Start() {
       target = Waypoints.points[0];
   }

   void Update() {
       Vector3 dir = target.position - transform.position;
       transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

       if(Vector3.Distance(transform.position, target.position) <= 0.2f ){
           GetNextWaypoint();
       }

       void GetNextWaypoint() {
           if(waypointIndex >= Waypoints.points.Length - 1) {
               Destroy(gameObject);
               return;
           }
           waypointIndex++;
           target = Waypoints.points[waypointIndex];
       }

   }

   public void TakeDamage (int amount)
	{
		health -= amount;

		if (health <= 0 && !isDead)
		{
			Die();
		}
	}

    void Die ()
	{
		isDead = true;

		Destroy(gameObject);
	}

}
