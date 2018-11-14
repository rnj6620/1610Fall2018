using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject {

	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Dying, Ending;
	
	// Update is called once per frame
	public void Run () {
		
		switch (GameState)
		{
			case GameStates.States.Starting:
				Starting.Invoke();
				break;
			
			case GameStates.States.Loading:
				Loading.Invoke();
				break;
			
			case GameStates.States.Playing:
				Playing.Invoke();
				break;
			case GameStates.States.Dying:
				Dying.Invoke();
				break;
			
			case GameStates.States.Ending:
				Ending.Invoke();
				break;
		}
	}
}
