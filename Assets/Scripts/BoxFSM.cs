using Unity.VisualScripting;
using UnityEngine;

namespace BoxFSM
{
/*    
	State machine for the box
	has 3 states: Idle, Spinning and Payout
	while Idle the player can spend money to start the box and the state will change to spinning.
	while in spinning state it is just a timer running for the amount of time you want the suspense of the box to be
	Payout state shows the weapon the player got from the box and the player can take it so the box goes back to Idle state
*/

	public enum BoxStates
	{
		Idle,
		Spinning,
		Payout
	}

	public enum BoxTriggers
	{
		PlayereInteract,
		BoxTimer
	}


	public interface Istates
	{
		BoxStates State { get; }


	}

}
