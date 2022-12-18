using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NewBehaviourScript : MonoBehaviour
{

    private NavMeshAgent _agent;
    [SerializeField] private Transform target;
    private Animator _anim;
     
   
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        _agent.SetDestination(target.position);



        _anim.SetFloat("Speed", _agent.velocity.magnitude);
    }
}
