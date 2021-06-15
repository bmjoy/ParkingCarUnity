using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    [SerializeField] Transform target;

    private NavMeshAgent agent;
    private Vector3 previousPosition;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag(CarSpawner.parkingTag ?? "Player").transform;

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        previousPosition = transform.position;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //FaceTarget();
    //}

    void Update()
    {
        agent.SetDestination(target.position);
        Vector3 currentDirection = (transform.position - previousPosition).normalized;
        previousPosition = transform.position;
        //transform.Rotate(currentDirection * 0.01f, Space.World);
        float angle = Vector3.Angle(currentDirection, new Vector3(0, 1, 0));
        if (currentDirection.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        } else
        {
            transform.rotation = Quaternion.Euler(0, 0, -angle);
        }
    }

    public void FaceTarget()
    {
        var turnTowardNavSteeringTarget = agent.steeringTarget;
        Vector3 direction = (turnTowardNavSteeringTarget - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    public void getOut() 
    {
        print(CarSpawner.parkingTag);
        target = GameObject.FindGameObjectWithTag(CarSpawner.parkingTag ?? "Player").transform;
    }
}