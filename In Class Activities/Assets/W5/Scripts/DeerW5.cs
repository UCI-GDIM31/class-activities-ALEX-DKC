using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 3.0f;
    [SerializeField] private float _turnSpeed = 180.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        Vector3 translation = Vector3.forward;
        transform.Translate(translation * _moveSpeed * Time.deltaTime);
    }






}