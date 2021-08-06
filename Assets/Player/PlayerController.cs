using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // gameObject -> ��� ��ũ��Ʈ�� ������ ���ӿ�����Ʈ
    // . -> ~��
    // SetActive() �޼���
    // transform

    /*
        Vector
        -> ũ��� ������ ���� ������
        -> ��ǥ�� (x, y, z)
        * Vector2 vs Vector3
        -Vector2 : (x, y)
        -Vector3 : (x, y, z)
     */

    void Start()
    {
        //SetActive() �޼��� .. ���� Ű��, ���� ���� ǥ��
        //bool isHidden = false; 
        //bool isDead = false; 

        //gameObject.SetActive(!(isHidden || isDead));


        // transform.position
        // transform.position = Vector2.one;   // (1, 1)
        // position ���� Vector�� �̿��ؼ��� ������ �� �ִ�.

        //Vector2 pos = transform.position;
        //pos.x += 3;     // (3, 0)
        //transform.position = pos;
    
        // 2. �÷��̾��� �̵�
        // *Input.GetKey() : Ű������ �Է��� �޴� �޼���
        // * frame - 60fps (frame per second) 

    }
    public float speed = 0.01f;
    public GameObject BulletPrefab;
    public float bulletSpeed = 100;
    //public GameObject Gun;    gameObject Gun�� ����Ƽ���� ������ �� player�� ���ӽ��� ����� �� ����

    void Update()
    {
       if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
       if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
       if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
       if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }

        // GetKeyDown ������ �� ���� 1ȸ�� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {

            for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);

                Vector3 bulletStartPositon = transform.position + new Vector3(0, 0.3f, 0);
                bulletStartPositon.y += i * 0.3f;
                bullet.transform.position = bulletStartPositon;

                //Vector3 bulletStartPos = Gun.transform.position;
                //bulletStartPos.y += i * 0.3f;
                //bullet.transform.position = bulletStartPos;


                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);  // (0, 1) * 100 = (0, 100)
             
            }

        }


    }

}
