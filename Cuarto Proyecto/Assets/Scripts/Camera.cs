using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;  


    
    void Start()
    {
    }
    void Update()
    {
        Vector3 position = transform.position;
        position.x = player.transform.position.x;
        transform.position = position;
    }
}
