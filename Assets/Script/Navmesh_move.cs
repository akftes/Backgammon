using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh_move : MonoBehaviour {
	private NavMeshAgent _thismove;
	Transform test;
	//Vector3 destenation_Pos;  
	Vector3 destenation_Position,vector3test;
	// Use this for initialization
	public void move(float x,float y,float z)
	{

		//this.transform.Rotate (0, 0, 180);

		_thismove =this.gameObject.GetComponent<NavMeshAgent>();
		destenation_Position = new Vector3(x,y,z);
		_thismove.SetDestination(destenation_Position);
		Invoke ("disablenavmeshagent", 2);

		
}
	//-------------------------------------
			void disablenavmeshagent()
			{
				NavMeshAgent tempnavmesh = new NavMeshAgent ();
				tempnavmesh =this.gameObject.GetComponent<NavMeshAgent> ();
			    tempnavmesh.enabled = false;
			}
}