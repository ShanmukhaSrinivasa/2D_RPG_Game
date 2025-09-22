using Unity.VisualScripting;
using UnityEngine;

public class StateMachine 
{
    public EntityState CurrentState {  get; private set; }

    public void Initialize(EntityState startState)
    {
        CurrentState = startState;
        CurrentState.Enter();
    }

    public void changeState(EntityState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

    public void UpdateActiveState()
    {
        CurrentState.Update();
    }
    
}
