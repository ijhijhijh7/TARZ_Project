using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;

public class LogoPanel : MonoBehaviour
{

    [Inject]
    MainSceneUI mainSceneUI;

    [Inject]
    SoundManager soundManager;

    Animator animator;



    [SerializeField] AudioClip[] clips;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }




    public void AddEvent()
    {
        soundManager.PlayBGM(E_Audio.Stage_1_BGM);
        this.UpdateAsObservable()
          .Where(x => Input.anyKeyDown)
          .Subscribe(x => {  mainSceneUI.MainMenuPanel.gameObject.SetActive(true); gameObject.SetActive(false); });
    }

    public void PlayLogoSound(int num)
    {
        soundManager.InstanceSFX(clips[num]);
    }
}
