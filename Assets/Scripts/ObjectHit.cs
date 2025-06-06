using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) // 무언가가 충돌할때마다 작업을 수행하는 메소드
    {   
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
