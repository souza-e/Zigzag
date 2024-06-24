using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followball : MonoBehaviour
{


    [SerializeField]
    private Transform ball;  // eixos da bola

    [SerializeField]
    private Vector3 dist; // distancia entre camera e alvo
    [SerializeField]
    private float vallerp;
    [SerializeField]
    private Vector3 posiCam, positaget; // informação de posição camera e alvo


    // Start is called before the first frame update
    void Start()
    {
        //diferença entre camera e bola
        dist = ball.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate() // so roda depois do Upadate roda todas as funções
    {
        if (!ballcontrol.gameOver)
        {

            followFunc();
        }



    }

    void followFunc()  // função para calcular e fazer a camera seguir o alvo
    {

        posiCam = transform.position;
        positaget = ball.position - dist;
        posiCam = Vector3.Lerp(posiCam, positaget, vallerp);
        transform.position = posiCam;

    }
}
