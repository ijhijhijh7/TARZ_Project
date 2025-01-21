using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayAudio : BaseAction
{
    public E_Audio audioType;

	/*public override void OnStart()
	{
		if(clipLength == -1)
		{
			clipLength = mob.soundManager.GetClipLength(audioType);
		}
	}*/

	public override TaskStatus OnUpdate()
	{
		mob.soundManager.PlaySFXMonster(audioType);
		return TaskStatus.Success;
	}
}