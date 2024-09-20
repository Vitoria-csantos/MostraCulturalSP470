using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Adiciona ao GameManager
            GameManager.Instance.AddCollectible();
            Destroy(gameObject); // Remove o item coletado
        }
    }
}
