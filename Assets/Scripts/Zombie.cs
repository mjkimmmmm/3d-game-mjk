using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    Animator animator = null;
    public GameObject playerObject = null;
    public float checkDistance = 5;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Idle();
    }

    //���, �߰�(�̵�), ����, �ǰ�, ����
    void Idle()
    {
        animator.SetBool("isMove", false);

        Vector3 playerVector = playerObject.transform.position;
        Vector3 zombieVector = transform.position;
        float playerZombieDistance = Vector3.Distance(zombieVector, playerVector);
        
        // ����� �÷��̾� ������ �Ÿ��� ���� ��ġ ������ ��(����� ��)
        if(playerZombieDistance < checkDistance)
        {
            // �߰��Ѵ�.
            Move();
        }

    }
    
    private void Move()
    {
        GetComponent<NavMeshAgent>().destination = playerObject.transform.position;
    }
}
