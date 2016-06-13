using UnityEngine;
using System.Collections;

public class NavMeshTesting : MonoBehaviour {

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ScreenPointToRay() takes a location on the screen
            // and returns a ray perpendicular to the viewport
            // starting from that location
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Cast the ray and look for a collision
            if (Physics.Raycast(ray, out hit, 200))
            {
                // If we detect a collision with the ground, 
                // tell the agent to move to that location
                agent.destination = hit.point;
            }
        }
    }
}