using UnityEngine;
using UnityEngine.UI;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Button _throwButton;
    [SerializeField] private Button _resetButton;
    [SerializeField] private Joint _joint;
    [SerializeField] private Transform _jointTarget;
    [SerializeField] private Rigidbody _projectile;
    [SerializeField] private Rigidbody _catapultSpoon;

    private Vector3 _startPosition;
    private Vector3 _projectileStartPosition;

    private void Awake()
    {
        _startPosition = _joint.transform.position;
        _projectileStartPosition = _projectile.transform.position;
    }

    private void OnEnable()
    {
        _throwButton.onClick.AddListener(Throw);
        _resetButton.onClick.AddListener(Reset);
    }

    private void OnDisable()
    {
        _throwButton.onClick.RemoveListener(Throw);
        _resetButton.onClick.RemoveListener(Reset);
    }

    private void Throw()
    {
        _joint.transform.position = _jointTarget.position;
    }

    private void Reset()
    {
        _joint.transform.position = _startPosition;
        _projectile.transform.position = _projectileStartPosition;
        _projectile.velocity = Vector3.zero;
        _projectile.rotation = Quaternion.Euler(Vector3.zero);
        _catapultSpoon.velocity = Vector3.zero;
        _catapultSpoon.rotation = Quaternion.Euler(Vector3.zero);
    }
}
