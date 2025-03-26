using UnityEngine;

public class RaycastSpawn : MonoBehaviour
{
    public GameObject sphere;

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
            }
        }
    }

}
