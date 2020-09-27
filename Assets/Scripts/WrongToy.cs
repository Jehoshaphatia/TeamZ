using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongToy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            // Subject child reacts positively by standing when the correct toy is picked up
            SubjectChildController.subjectChildController.PlayChangePoseAnimation();
            AudioManager.audioManager.PlayNarMHFeelBetter();
        }


    }
}
