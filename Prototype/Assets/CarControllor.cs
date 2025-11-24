using UnityEngine;
using UnityEngine.Splines;

public class CarControllor : MonoBehaviour
{
    [SerializeField] GameObject banana;
    [SerializeField] GameObject red;
    [SerializeField] GameObject green;
    [SerializeField] Animator anim;
    [SerializeField] SplineAnimate car;

    int lap = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item Box"))
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("ThrowBanana1"))
        {
            Destroy(other.gameObject);
            anim.SetLayerWeight(1, 1);
            Instantiate(banana, gameObject.transform.position, Quaternion.identity);
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            lap++;
            if (lap >= 3)
            {
                car.MaxSpeed = 0;
            }
        }
    }
}