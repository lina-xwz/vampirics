using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(5, 0, 2);
    
    void Update()
    {
        // Мгновенное перемещение
        transform.position = targetPosition;
    }
}