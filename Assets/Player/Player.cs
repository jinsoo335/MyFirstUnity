using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100.0f;

    public float Health
    {
        get { return health; }
    }

    void TakeDamage(float value)
    {
        health -= value;
        Debug.Log("Player�� ü�� : " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);    // �ڱ� �ڽ��� ���ֶ�!
    }

    public float GetHelth()
    {
        return health;
    }

    void OnCollisionEnter2D(Collision2D coll)   // collider�� �߻��� �浹�� ����, Collision2D -> �浹 �� ��ü�� �����´� �ε��� �� ������ �� ����
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(coll.gameObject);
        }


    }
}
