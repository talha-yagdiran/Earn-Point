using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public int cubeCount = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            cubeCount--;

            Debug.Log("Bir küp alana girdi");

            if (cubeCount <= 0)
            {
                Debug.Log("WIN");
            }
        }
    }
}