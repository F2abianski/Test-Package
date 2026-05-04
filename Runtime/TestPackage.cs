namespace TestPackage
{
    using UnityEngine;

    public class TestPackage : MonoBehaviour
    {
        [SerializeField] private string message;
        void Start()
        {
            DebugMessage();
        }

        public void DebugMessage()
        {
            Debug.Log("Message");
        }
    }

}
