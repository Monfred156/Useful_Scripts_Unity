using UnityEngine;
using UnityEngine.AI;

public class CharacterControllerTopDown : MonoBehaviour
{
    private Camera _camera;
    private NavMeshAgent _agent;
    private void Start()
    {
        _camera = GameObject.Find("Main Camera").gameObject.GetComponent<Camera>();
        _agent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
