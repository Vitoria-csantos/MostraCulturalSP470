using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    public void Collect()
    {
        GameManager.Instance.AddCollectible(); // Atualizar a contagem de itens
        // Mostrar mensagem de coleta (opcional)
        // uiManager.ShowCollectibleMessage("Item Coletado!");
    }
}