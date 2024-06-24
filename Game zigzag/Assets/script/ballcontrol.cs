using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{

    [SerializeField]
    private int moedacont;

    [SerializeField]
    private float vel = 0.02f;

    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(vel, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballMoviment(); // chama o metodo quando ouver a ação de clica no botão espaço 
        }

        if (!Physics.Raycast(transform.position, Vector3.down, 1))
        {
            gameOver = true;
            rb.useGravity = true;

        }
        if (gameOver)
        {

            print("CAINDOOOOOOOOOOOOOOO");
        }
        Debug.DrawRay(transform.position, Vector3.down, Color.blue);
    }
    void ballMoviment() // metodo para fazer a bolinha se mover
    {

        if (rb.velocity.x > 0) // se a bolinha estiver andando no eixo x ela poderar se movimentar o eixo z
        {
            rb.velocity = new Vector3(0, 0, vel);

        }
        else if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(vel, 0, 0);
        }


    }
    void OnTriggerEnter(Collider collider)
    {

        Debug.Log("colidiu");
        if (collider.gameObject.CompareTag("moeda"))
        {

            Destroy(collider.gameObject);
            moedacont++;


        }
    }


}