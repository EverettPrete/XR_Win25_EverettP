using UnityEngine;

public class Float : MonoBehaviour
{

    Animator animator;
    [SerializeField] float heavy = 0;

    Animator animator1;
    [SerializeField] float spin = 0;


    Animator animator2;
    [SerializeField] float slide = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator1 = GetComponent<Animator>();
        animator2 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("weight", heavy);
        animator1.SetFloat("weight", heavy);
        animator2.SetFloat("weight", heavy);
    }
}
