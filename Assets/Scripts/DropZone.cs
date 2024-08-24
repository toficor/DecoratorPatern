
using DG.Tweening;
using UnityEngine;

namespace CardGame
{
    public class DropZone : MonoBehaviour
    {

        private void OnMouseDown()
        {
            if(CardManager.Instance.SelectedCard != null)
            {
                CardManager.Instance.SelectedCard.MoveToAndDestroy(transform.position);
                CardManager.Instance.SelectedCard.Card.Play();
                var total = CardManager.Instance.SelectedCard.Card.Play();
                Debug.Log("total: "+ total);
            }
           
        }

    }
}
