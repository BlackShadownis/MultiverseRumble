using UnityEngine;

namespace MultiverseRumble
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card") ]
    public class Card : ScriptableObject
    {
        public string name;
        public string description;


        public Sprite artwork;

        public int health;
        public int streght;
        public int speed;
        public int smart;
        public int rest;
    }
}
