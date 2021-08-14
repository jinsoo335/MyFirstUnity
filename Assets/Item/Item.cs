using UnityEngine;

namespace ItemNS
{
    public abstract class Item : MonoBehaviour
    {
        // 1. 시간이 지나면 사라지도록
        // 2. 아이템을 획득하면 적용되도록

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



