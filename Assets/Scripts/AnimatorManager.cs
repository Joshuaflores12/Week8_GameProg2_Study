using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    int horizontal,vertical;

    private void Awake()
    {
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }
    
    public void UpdateAnimatorValues(float horizontalMovement,float verticalMovement)
    {
        PlayerManager.Instance.animator.SetFloat(horizontal, horizontalMovement,0.1f,Time.deltaTime);
        PlayerManager.Instance.animator.SetFloat(vertical, verticalMovement, 0.1f,Time.deltaTime);
    }
}
