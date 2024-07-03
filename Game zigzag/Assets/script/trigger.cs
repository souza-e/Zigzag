using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb; //corpo riggido


    void Start()
    {

        rb = GetComponent<Rigidbody>(); //ele vai obter o corpo colisor do objeto que usa esse script

    }

    void OnTriggerExit(Collider col)// evento de colisão
    {
        if (col.gameObject.CompareTag("Player"))//se o objeto que colidio for o player então...
        {
            rb.useGravity = true;  // objeto terá a gravidade ativada
            Destroy(gameObject, 0.3f); // e depois de 3 segundos irá destruir
            spawnplataform.groundnumscene--;


        }
    }
}
