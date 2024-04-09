using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum AIState
{
    movingTowardsPlayer,
    movingRandomly,
}

public class enemyAIscript : MonoBehaviour
{

    public AIState currentAIState;
    public NavMeshAgent uAgent;
    public GameObject uDestinationObject;
    public Vector3 randomPos;
    public float changeStateTimer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeStateTimer -= Time.deltaTime;
        if (changeStateTimer <= 0)
        {
            changeStateTimer = 2;
            if (currentAIState == AIState.movingTowardsPlayer)
            {
                currentAIState = AIState.movingRandomly;
                randomPos = new Vector3(Random.Range(-15f, 15f), 0, Random.Range(-15f, 15f));
            }
            else if (currentAIState == AIState.movingRandomly)
            {
                currentAIState = AIState.movingTowardsPlayer;
            }
        }
        
        if (currentAIState == AIState.movingTowardsPlayer)
        {
            uAgent.destination = uDestinationObject.transform.position;
            if (Vector3.Distance(transform.position,uDestinationObject.transform.position) < 1.5f)
            {
                Destroy(uDestinationObject);
            }
        }

        if (currentAIState == AIState.movingRandomly)
        {
            uAgent.destination = randomPos;
        }
    }
}
