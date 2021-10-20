using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class animControl : MonoBehaviour
{
    Animator animator = new Animator();
    public AnimationClip[] animationClips;
    int animId;
    public TextMeshProUGUI text;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        text.text = animationClips[animId].name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (animId < animationClips.Length)
            {
                animId += 1;
            }
            text.text = animationClips[animId].name;
            animator.Play(animationClips[animId].name);
        }
        else
             if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (animId > 0)
            {
                animId -= 1;
            }
            text.text = animationClips[animId].name;
            animator.Play(animationClips[animId].name);
        }
    }
}
