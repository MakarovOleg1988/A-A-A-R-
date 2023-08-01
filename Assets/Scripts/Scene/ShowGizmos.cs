using UnityEngine;

public class ShowGizmos : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 0.1f);
        Gizmos.color = Color.green;
    }
}
