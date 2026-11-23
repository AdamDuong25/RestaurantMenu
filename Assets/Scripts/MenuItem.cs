using UnityEngine;

public class MenuItem : MonoBehaviour
{
    [System.Serializable]
    public class menuItem
    {
        public int ID;
        public string productName;
        public string description;
        public string category;
        public float price;
        public Sprite icon;
        public GameObject prefab;
    }
}
