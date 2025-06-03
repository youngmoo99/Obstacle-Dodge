using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField]
    float xValue = 0.01f;
    [SerializeField]
    float yValue = 0f;

    [SerializeField]
    float zValue = 0f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(xValue, yValue, zValue); // Translate(x,y,z) 현재 좌표에서 좌표만큼 이동
    }
}
