using UnityEngine;

public class Enemy : MonoBehaviour      // MonoBehaviour를 상속받는 클래스의 객체 생성시 new를 통해 생성하면 경고 + 문제가 생김
{
    // 유니티에서의 객체 생성
    // 1. 생성자를 통한 객체 생성
    // 2. 스크립트를 게임오브젝트에 붙임으로서 객체 생성

    // * 피격 과정
    // 1. 적군과 투사체(총알)가 충돌
    // - Collider
    // 2. 충돌 시 적군의 체력이 감소
    // - OnCollisionEnter2D -> 콜라이더끼리의 충돌을 스크립트로 가져온다.
    // - OnCollisionStay2D, OnCollisionExit2D
    // 3. 충돌 후 총알이 소멸

    // * tag
    // - 유니티의 게임오브젝트를 구분하기 위한 요소

    private float health = 50.0f;
    public float Speed = 1000f;

    public float Health
    {
        get { return health; }
    }

    public void TakeDamage(int value)
    {
        health -= value;
        Debug.Log("Enemy의 체력 : " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float value)
    {
        float amount = (health * value);
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        EventManager.RunEnemyDieEvent();
        Destroy(gameObject);    // 자기 자신을 없애라!
    }

    public float GetHelth()
    {
        return health;
    }

    void OnCollisionEnter2D(Collision2D coll)   // collider로 발생한 충돌을 감지, Collision2D -> 충돌 그 자체를 가져온다 부딪인 놈도 가져올 수 있음
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            // 총알을 소멸시켜라
            // -> 나랑 출돌한 놈을 없애라!

            coll.gameObject.SetActive(false);
        }


    }

    public virtual void Move()
    {

    }

}
