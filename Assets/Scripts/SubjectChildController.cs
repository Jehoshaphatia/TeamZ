using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectChildController : MonoBehaviour
{
    public static SubjectChildController subjectChildController;
    public Animator sbjChildAnim;

    private void Awake()
    {
        subjectChildController = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayStandUpAnimation()
    {
        // transition to olivia's standing and talking animation
        sbjChildAnim.SetBool("isStandUp", true);
    }

    public void PlayChangePoseAnimation()
    {
        // transition to olivia's standing and talking animation
        sbjChildAnim.SetBool("isChangeSitPos", true);
    }


}
