using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState currentState;

    private void Start(){
        
    }

    private void Update(){
        currentState?.Update();
    }

    public void ChangeState(PlayerState newState){
        currentState?.OnExit();
        currentState = newState;
        currentState.OnEnter();
    }
}
