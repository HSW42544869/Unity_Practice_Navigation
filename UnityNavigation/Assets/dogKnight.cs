using UnityEngine;
using UnityEngine.AI;

public class dogKnight : MonoBehaviour
{
    public float speed;
    private NavMeshAgent agent;
    private Animator ani;
    private Vector3 position;
    private void Awake()
    {
        ani = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move();
            ani.SetBool("跑步開關", true);
        }

        float distanceToTarget = Vector3.Distance(transform.position, position);
        print(distanceToTarget.ToString());
        if (distanceToTarget < 1)
        {
            ani.SetBool("跑步開關", false);
        }
    }
    private void Move()
    {
        position = new Vector3(Random.Range(-13.0f, 3.0f), 0, Random.Range(-10.0f, 6.0f));
        agent.SetDestination(position);
    }
}
