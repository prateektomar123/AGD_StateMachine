using System.Collections.Generic;

namespace StatePattern.Enemy
{
    public class OnePunchManStateMachine
    {
        private OnePunchManController Owner;
        private IState currentState;
        protected Dictionary<States, IState> StatesI = new Dictionary<States, IState>();

        public OnePunchManStateMachine(OnePunchManController Owner)
        {
            this.Owner = Owner;
            CreateStates();
            SetOwner();
        }

        private void CreateStates()
        {
            StatesI.Add(States.IDLE, new IdleState(this));
            StatesI.Add(States.ROTATING, new RotatingState(this));
            StatesI.Add(States.SHOOTING, new ShootingState(this));
        }

        private void SetOwner()
        {
<<<<<<< Updated upstream:Assets/Scripts/Enemy/OnePunchMan/OnePunchManStateMachine.cs
            foreach(IState state in States.Values)
=======
            foreach (IState state in StatesI.Values)
>>>>>>> Stashed changes:Assets/Scripts/Enemy/OnePunchMan/States/OnePunchManStateMachine.cs
            {
                state.Owner = Owner;
            }
        }

        public void Update() => currentState?.Update();

        protected void ChangeState(IState newState)
        {
            currentState?.OnStateExit();
            currentState = newState;
            currentState?.OnStateEnter();
        }

        public void ChangeState(States newState) => ChangeState(StatesI[newState]);
    }

    public enum OnePunchManStates
    {
        IDLE,
        ROTATING,
        SHOOTING
    }
}