using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

public class IsInAttackRange : BaseCondition
{
    public override TaskStatus OnUpdate()
    {
        if (mob == null)
        {
            Debug.LogWarning("몬스터가 존재하지 않습니다!");
            return TaskStatus.Failure;
        }

        if (mob.Dist <= mob.Stat.InAttackRange) // InAttackRange
        {
            if ((E_Monster)mob.MyType == E_Monster.BossMob)
            {
                mob.inGameUI.InitEnemyHP(mob.Stat.Health);
            }
            return TaskStatus.Success;
        }

        return TaskStatus.Failure;
    }
}