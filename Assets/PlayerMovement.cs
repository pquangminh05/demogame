using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
// demopart5
void Update()
    {
        var worldPoint = 
    Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
        Debug.Log(Input.mousePosition);
    } 
}
