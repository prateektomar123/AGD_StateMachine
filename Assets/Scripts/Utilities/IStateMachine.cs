using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateMachine
{
    public void ChangeState(States newState);
}
