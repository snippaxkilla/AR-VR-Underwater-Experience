using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject GrapplingHook;
    [SerializeField] private float MaxDistance = 10f;
    [SerializeField] private float PullSpeed = 5f;

    private bool isPullingBack = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent == GroupedGarbage.transform)
        {
            StartPullback();
        }
    }

    private void StartPullback()
    {
        isPullingBack = true;
    }


    private void Update()
    {
        if (isPullingBack)
        {
            Vector3 direction = GrapplingHook.transform.position - GroupedGarbage.transform.position;

            if (direction.magnitude > MaxDistance)
            {
                direction.Normalize();
                direction *= PullSpeed * Time.deltaTime;

                GroupedGarbage.transform.position += direction;
            }
        }
    }
}