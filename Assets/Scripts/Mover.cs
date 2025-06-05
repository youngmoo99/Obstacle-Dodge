using System;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 8f;


    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {   
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue =  Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //키보드 입력 접근 수평(Horizontal) 혹은 수직(Vertical) --> 좌,우
        float yValue =  0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // 위, 아래
        //일관되게 움직이기 위해 Time.deltaTime 사용 
        transform.Translate(xValue, yValue, zValue); // Translate(x,y,z) 현재 좌표에서 좌표만큼 이동
    }
}
