using UnityEngine;
using UnityEngine.UI;

public class Swinger : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Button _button;
    [SerializeField] private float _swingForce;

    private void OnEnable()
    {
        _button.onClick.AddListener(AddForce);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(AddForce);
    }

    private void AddForce()
    {
        _rigidbody.AddForce(_rigidbody.transform.forward * _swingForce);
    }
}
