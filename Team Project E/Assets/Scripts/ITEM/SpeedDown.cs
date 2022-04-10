using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour
{

   

    Coroutine DeBuff;
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other) //�浹�� 
    {
        
        if (other.gameObject.tag == "Untagged") // �±��� �̸����� �Ǵ�
        {

            
                if (DeBuff != null)
                {
                    StopCoroutine((DeBuff));
                }
                DeBuff = StartCoroutine(DownSpeed(5)); 

            gameObject.GetComponent<SphereCollider>().enabled = false; 
            gameObject.GetComponent<MeshRenderer>().enabled = false;

        }
    }

    IEnumerator DownSpeed(float t) // t=�ӵ������� ���ӽð� 
    {
        SPlayer MSpeed = GameObject.Find("Player").GetComponent<SPlayer>(); //�÷��̾� ��ũ��Ʈ ����

        MSpeed.MoveSpeed = 0.5f;

        yield return new WaitForSeconds(t); 

        MSpeed.MoveSpeed = 5f;

        Destroy(this.gameObject);
    }
} 
