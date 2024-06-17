using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 clickPosition;
    private bool isCanJump;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("crash");
    }
    private void OnCollisionStay(Collision collision)
    {
       // Debug.Log("In contact");
       

        ContactPoint[] contacts = collision.contacts;

        Vector3 otherNormal = contacts[0].normal; 

        Vector3 upVector = new Vector3(0,1,0);

        float dotUN = Vector3.Dot(upVector,otherNormal);

        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;

        if (dotDeg <= 45)
        {

            isCanJump = true;

        }

        }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("leave");
        isCanJump = false;
    }

    [SerializeField]
    private float jumpPower = 25;

   


    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump && Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;

            if (dist.sqrMagnitude == 0) { return; }

            rb.velocity = dist.normalized * jumpPower;
        }
    }
}
