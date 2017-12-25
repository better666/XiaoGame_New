using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RedStone.UI;

namespace RedStone
{
    public class SosPlayer : MonoBehaviour
    {
        public Transform cardRoot;
        public Text playerName;
        public Text effect;

        public List<SosCard> m_handCards = new List<SosCard>();

        public void TakeCard(int cardID)
        {
            SosCard newCard = new SosCard();

            m_handCards.Add(newCard);
        }

        public void PlayCard(int cardID)
        {
            m_handCards.Remove(m_handCards.First(a=>a.);
        }

        public void SetReady(bool isReady)
        {

        }
    }
}