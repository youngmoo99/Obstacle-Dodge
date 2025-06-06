using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timeToWait = 3f;
    MeshRenderer meshRenderer;
    Rigidbody myrigidbody;
    void Start()
    {   
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.useGravity = false;

    }

    void Update()
    {   
        if(Time.time > timeToWait)
        {          
            //Debug.Log("Lookout Below!");
            meshRenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
        
    }
}
