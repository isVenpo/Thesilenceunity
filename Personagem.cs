using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Velocidade de movimento
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Adicionar um Box Collider ao objeto
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();

        // Ajustar o tamanho do colisor (opcional)
        boxCollider.size = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        // Chama o método de movimento
        Movement();
    }

    void Movement()
    {
        // Obtém o input do teclado para movimentação horizontal
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calcula o movimento baseado no input e na velocidade
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;

        // Aplica o movimento ao objeto
        transform.position += movement;
    }
}