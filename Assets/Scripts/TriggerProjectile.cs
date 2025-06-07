using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{   
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {   
            projectile1.SetActive(true); //오브젝트 활성화
            projectile2.SetActive(true); //오브젝트 활성화
            projectile3.SetActive(true); //오브젝트 활성화
            Destroy(gameObject);
            

        }
    }

}
