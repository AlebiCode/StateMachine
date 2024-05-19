using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : IState
{
    public virtual void Enter()
    {
    }

    public virtual void Execute()
    {
    }

    public virtual void Exit()
    {
    }

}
