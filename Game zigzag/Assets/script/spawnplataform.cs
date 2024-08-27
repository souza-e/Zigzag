using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplataform : MonoBehaviour
{
    [SerializeField]
    private GameObject ground, moeda; // chão
    [SerializeField]
    private float sizeXZ; // tamanho do chão no eixo X Z
    [SerializeField]
    private Vector3 LastPosi; // ultima posição da plataforma
    [SerializeField]
    private int limitground;
    public static int groundnumscene;

    // Start is called before the first frame update
    void Start()
    {
       
       
        LastPosi = ground.transform.position;  // ao iniciar essa variavel vai pegar a posição do chão setado
        sizeXZ = ground.transform.localScale.x; // o tomanho do chão no Eixo X
        groundnumscene = 0;



        StartCoroutine(generatGroundinGame());

    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnX() // irá instanciar o chão colado com outro chão no eixo x
    {

        Vector3 tempPosi = LastPosi;
        tempPosi.x += sizeXZ;
        LastPosi = tempPosi;
        Instantiate(ground, tempPosi, Quaternion.identity);

        int rand = Random.Range(0, 5);

        if (rand <= 1)
        {
            Instantiate(moeda, new Vector3(tempPosi.x, tempPosi.y + 0.2f, tempPosi.z), moeda.transform.rotation);

        }

    }

    void spawnZ() // irá instanciar o chão colado com outro chão no eixo z 
    {
        Vector3 tempPosi = LastPosi;
        tempPosi.z += sizeXZ;
        LastPosi = tempPosi;
        Instantiate(ground, tempPosi, Quaternion.identity);

        int rand = Random.Range(0, 5);

        if (rand <= 1) // sorteio de moedas
        {
            Instantiate(moeda, new Vector3(tempPosi.x, tempPosi.y + 0.2f, tempPosi.z), moeda.transform.rotation);

        }
    }
    void groundgenerete() //sorteio de geração de plataforma no eixo x e z
    {
        int temp = Random.Range(0, 5);

        if (groundnumscene < limitground)
        {
            if (temp < 3)
            {
                spawnX();
                groundnumscene++;

            }
            else if (temp >= 3)
            {

                spawnZ();
                groundnumscene++;
            }
        }

    }
    IEnumerator generatGroundinGame() //rotina para gerar plataforma
    {

        while (ballcontrol.gameOver != true) // enquanto não for Game over
        {
            yield return new WaitForSeconds(0.2f); // a cada 2 frames irar gera uma plataforma
            groundgenerete(); // chama a fun~]ao
        }

    }



}

