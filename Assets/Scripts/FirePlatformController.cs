using System.Collections;
using UnityEngine;

public class FirePlatformState : MonoBehaviour
{
    private Transform transform;

    [SerializeField] private float timeBetween = 2f;
    [SerializeField] private bool reverse = false;

    private bool isOn = true;

    private void Start()
    {
        transform = GetComponent<Transform>();
        if (reverse)
        {
            isOn = !isOn;
        }

        IEnumerator cortoutine = PlayAnimationCoroutine();
        StartCoroutine(cortoutine);
    }

    private IEnumerator PlayAnimationCoroutine()
    {
        while (true)
        {
            isOn = !isOn;
            // Trigger the animation by its name.
            selectChild();
            // Wait for 5 seconds before playing the animation again.
            yield return new WaitForSeconds(timeBetween);
        }
    }

    private void selectChild()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.name == "Fire On")
            {
                if (isOn)
                {
                    child.gameObject.SetActive(true);
                }
                else
                {
                    child.gameObject.SetActive(false);
                }
            }

            if (child.gameObject.name == "Fire Off")
            {
                if (isOn)
                {
                    child.gameObject.SetActive(false);
                }
                else
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
    }
}
