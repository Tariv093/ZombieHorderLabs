using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : HealthComponent
{

    private StateMachine zStateMachine;

    private void Awake()
    {
        zStateMachine = GetComponent<StateMachine>();

    }
   
    public override void Destroy()
    {


       // base.Destroy();


        zStateMachine.ChanceState(ZombieStateType.Dead);
    }
}
