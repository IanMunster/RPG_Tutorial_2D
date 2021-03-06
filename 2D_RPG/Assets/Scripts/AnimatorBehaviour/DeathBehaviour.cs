﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Death behaviour.
/// Deselect Enemy on Death
/// </summary>

public class DeathBehaviour : StateMachineBehaviour {

	// Keeps track of Time passed
	private float timePassed;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		// Destroy Hitbox Child on Object
		Destroy (animator.transform.GetChild(0).gameObject);
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		// Update Time Passed
		timePassed += Time.deltaTime;
		if (timePassed >= 5) {
			// Remove the Gameobject through NPC's Character Removed Function
			animator.GetComponent<NPC> ().OnCharacterRemoved ();
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//	
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
