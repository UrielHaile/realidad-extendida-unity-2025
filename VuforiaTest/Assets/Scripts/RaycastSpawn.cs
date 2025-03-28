using UnityEngine;
using UnityEngine.AI;

public class RaycastSpawn : MonoBehaviour
{
    public GameObject sphere;
    public NavMeshAgent agent;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.position);
                Debug.LogWarning(hit.point);
                Instantiate(sphere, hit.point, Quaternion.identity);
                agent.destination = hit.point;
            }
        }
    }

}
