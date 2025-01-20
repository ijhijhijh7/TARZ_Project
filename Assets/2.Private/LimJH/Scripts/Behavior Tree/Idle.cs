using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class Idle : BaseAction
{
    public override TaskStatus OnUpdate()
    {
        //mob.soundManager.PlaySFX(E_Audio.Base_Idle);
        return TaskStatus.Running;
    }
}