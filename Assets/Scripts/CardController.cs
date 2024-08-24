
using DG.Tweening;
using UnityEngine;

namespace CardGame
{
    public class CardController: MonoBehaviour
    {
        [SerializeField] private CardDefinition definition;
        [SerializeField] private Ease ease = Ease.OutBack;
        [SerializeField] private float duration = 0.5f;
        public ICard Card { get;  set; }

        void Awake() => Card = CardFactory.Create(definition);

        private void OnMouseDown()
        {
            if (CardManager.Instance.SelectedCard == null)
            {
                CardManager.Instance.SelectedCard = this;
            }
            else
            {
                CardManager.Instance.Decorate(this);
                CardManager.Instance.SelectedCard = null;   
            }
        }

        public void MoveTo(Vector3 position)
        {
            transform.DOMove(position, duration).SetEase(ease);
        }

        public void MoveToAndDestroy(Vector3 position) 
        {
            transform.DOMove(position, duration).SetEase(ease).OnComplete(() => Destroy(gameObject));
        }
    }
}
