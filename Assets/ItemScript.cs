using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        //Debug.Log("Enter");
        DestroySelf()
;    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void OnTriggerStay(UnityEngine.Collider other)
    {
        //Debug.Log("Stay");
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        //Debug.Log("Exit");
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
