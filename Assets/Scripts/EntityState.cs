using UnityEngine;

public abstract class EntityState 
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(Player player ,StateMachine stateMachine, string stateName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }
    
    public virtual void Enter()
    {
        // everytime the state will be changed, Enter function will be called
        Debug.Log("I Entered " + stateName);
    }

    public virtual void Update()
    {
        // we are going to run logic of the state here
        Debug.Log("I run update of " + stateName);
    }

    public virtual void Exit()
    {
        //this will be called everytime we exit state and change to new state
        Debug.Log("I exited " + stateName);
    }
}
