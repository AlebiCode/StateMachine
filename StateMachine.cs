using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateMachine
{

    private State currentState;

    public StateMachine(State startingState)
    {
        currentState = startingState;
        currentState.Enter();
    }

    public void ChangeState(State state)
    {
        currentState.Exit();
        currentState = state;
        currentState.Enter();
    }

    public void Execute()
    {
        currentState.Execute();
    }

}
