using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	public float LookRedius = 50f;

	public Transform target;

	private NavMeshAgent agent;

	void Start () {

		target = PlayerManager.instance.Player.transform;

		agent = GetComponent<NavMeshAgent> ();
		//if (target != null) {
		//	agent.SetDestination (target.position);
		
		//}
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance (target.position,transform.position);

		if (distance <= LookRedius) {

			agent.SetDestination (target.position);

		}
			
		
	}

	void OnDrawGizmosSelected(){

		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, LookRedius );
	




	}




}
