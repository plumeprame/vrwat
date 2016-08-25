using UnityEngine;
using System.Collections;


public class Patrol : MonoBehaviour {
	static Animator anim;
	public Transform goal;
	public Transform player;
	private NavMeshAgent agent;
	void Start () {
		 agent = GetComponent<NavMeshAgent>();
		agent.destination = goal.position;
		anim = GetComponent<Animator>();

	}
	void Update (){
		// Check if we've reached the destination

		if (!agent.pathPending) {
			if ( Vector3.Distance( agent.destination, agent.transform.position) <= agent.stoppingDistance)
			{
				if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f) {
					Debug.Log ("reach");
					anim.SetFloat ("Walking", 0.0f);
					Vector3 direction = player.position - this.transform.position;
//					direction.y = 0;
					this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction),0.1f);
					Debug.Log ("here");
				} 
			}else {
				Debug.Log ("walking");
				anim.SetFloat ("Walking", 0.2f);
			}
		} 
	}
}