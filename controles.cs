using UnityEngine;

public class MovimentoPersonagem : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do personagem

    void Update()
    {
        // Movimento horizontal
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * movimentoHorizontal * velocidade * Time.deltaTime);

        // Movimento vertical
        float movimentoVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * movimentoVertical * velocidade * Time.deltaTime);
    }
}
