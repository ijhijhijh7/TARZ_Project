using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Explosive : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] GameObject ExplosivePoint;
    public event Action onExplosiveBomb;
    [SerializeField] private SoundManager soundManager;

    private void Awake()
    {
        if (soundManager == null)
        {
            soundManager = FindObjectOfType<SoundManager>(); // 씬 전체에서 SoundManager를 찾음
        }
    }

    private void Start()
    {
        // 몬스터 콜라이더 가져오기
        GameObject monster = GameObject.FindWithTag("Monster");
        if (monster != null)
        {
            Collider monsterCollider = monster.GetComponent<Collider>();
            Collider projectileCollider = GetComponent<Collider>();

            // 몬스터와 투척물 간의 충돌 무시
            if (monsterCollider != null && projectileCollider != null)
            {
                Physics.IgnoreCollision(monsterCollider, projectileCollider);
            }
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Monster"))
        {
            return; // 충돌 무시
        }

        // ExplosivePoint 프리팹 생성
        if (ExplosivePoint != null)
        {
            Instantiate(ExplosivePoint, transform.position, Quaternion.identity);
            onExplosiveBomb?.Invoke();
        }

        soundManager.PlaySFXMonster(E_Audio.Boss_Skill2_Bomb);
        // 현재 오브젝트 파괴
        Destroy(gameObject);
    }
}
