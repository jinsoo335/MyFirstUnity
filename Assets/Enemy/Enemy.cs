using UnityEngine;

public class Enemy : MonoBehaviour      // MonoBehaviour�� ��ӹ޴� Ŭ������ ��ü ������ new�� ���� �����ϸ� ��� + ������ ����
{
    // ����Ƽ������ ��ü ����
    // 1. �����ڸ� ���� ��ü ����
    // 2. ��ũ��Ʈ�� ���ӿ�����Ʈ�� �������μ� ��ü ����

    // * �ǰ� ����
    // 1. ������ ����ü(�Ѿ�)�� �浹
    // - Collider
    // 2. �浹 �� ������ ü���� ����
    // - OnCollisionEnter2D -> �ݶ��̴������� �浹�� ��ũ��Ʈ�� �����´�.
    // - OnCollisionStay2D, OnCollisionExit2D
    // 3. �浹 �� �Ѿ��� �Ҹ�

    // * tag
    // - ����Ƽ�� ���ӿ�����Ʈ�� �����ϱ� ���� ���

    private float health = 50.0f;
    public float Speed = 1000f;

    public float Health
    {
        get { return health; }
    }

    public void TakeDamage(int value)
    {
        health -= value;
        Debug.Log("Enemy�� ü�� : " + health);

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
        Destroy(gameObject);    // �ڱ� �ڽ��� ���ֶ�!
    }

    public float GetHelth()
    {
        return health;
    }

    void OnCollisionEnter2D(Collision2D coll)   // collider�� �߻��� �浹�� ����, Collision2D -> �浹 �� ��ü�� �����´� �ε��� �� ������ �� ����
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            // �Ѿ��� �Ҹ���Ѷ�
            // -> ���� �⵹�� ���� ���ֶ�!

            coll.gameObject.SetActive(false);
        }


    }

    public virtual void Move()
    {

    }

}
