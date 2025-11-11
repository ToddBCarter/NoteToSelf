using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private UnityEngine.AI.NavMeshAgent Agent;
    [SerializeField] private GameObject Follow;

    void Start()
    {

        Agent.SetDestination(Follow.transform.position);
        //playerLocation.position;


        //1 Find player position
        //2 Velocity of object towards position of player
        //3 Stop when within cetain distance of player
        //4 IF player greater than that distance of player, repeat step 2

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
