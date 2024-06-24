using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;


    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            rb.useGravity = true;
            Destroy(gameObject, 0.3f);


        }
    }
}
