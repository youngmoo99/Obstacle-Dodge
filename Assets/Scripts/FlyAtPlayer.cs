using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{   
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;


    void Start()
    {
        playerPosition = player.transform.position;
        
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed); // MoveTowards(현재, 타겟, 속도)
    }

    void DestroyWhenReached()
    {   
        if(transform.position == playerPosition) //목표지점에 도착하면
        {
            Destroy(gameObject); //자신 파괴
        }    
    }
}
