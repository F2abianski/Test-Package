namespace TestPackage
{
    using LitMotion;
    using LitMotion.Extensions;
    using UnityEngine;
    using UnityEngine.UI;

    public class LitMotionTest : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Image image;
        [SerializeField] private float duration = .25f;
        [SerializeField] private LitMotion.Ease ease;

        void Reset()
        {
            target = transform;
        }
        void Start()
        {
            LMotion.Create(new Vector3(0, -3, 0), new(0, 3, 0), duration).WithEase(ease).BindToPosition(target);

            LMotion.Create(0f, 10f, 2f)
                .BindToUnityLogger();

            LMotion.Create(Color.white, Color.gray, duration).WithLoops(-1, LoopType.Yoyo).Bind(image, (x, image) => image.color = x);
        }
    }

}
