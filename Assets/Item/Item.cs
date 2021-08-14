using UnityEngine;

namespace ItemNS
{
    public abstract class Item : MonoBehaviour
    {
        // 1. �ð��� ������ ���������
        // 2. �������� ȹ���ϸ� ����ǵ���

        private void Start()
        {
            DestroyAfterTime();
        }

        public abstract void DestroyAfterTime();
        public abstract void ApplyItem();

        public void DestroyThis()
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.CompareTag("Player"))
            {
                ApplyItem();
            }
        }
    }

    public interface IEffect
    {
        void GetOpaque();
    }

}



