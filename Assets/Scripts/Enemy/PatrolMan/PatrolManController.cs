using System.Collections;
using System.Collections.Generic;
using StatePattern.Enemy;
using StatePattern.StateMachine;
using UnityEngine;

public class PatrolManController : EnemyController
{
    private PatrolManStateMachine stateMachine;

    // Constructor initializes the controller and sets the initial state to IDLE.
    public PatrolManController(EnemyScriptableObject enemyScriptableObject) : base(enemyScriptableObject)
    {
        enemyView.SetController(this);
        CreateStateMachine();
        stateMachine.ChangeState(States.IDLE);
    }
    private void CreateStateMachine() => stateMachine = new PatrolManStateMachine(this);

    // Override to update the enemy's state machine.
    public override void UpdateEnemy()
    {
        if (currentState == EnemyState.DEACTIVE)
            return;

        stateMachine.Update();
    }
}
