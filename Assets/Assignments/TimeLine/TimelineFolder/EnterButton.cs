using UnityEngine;
using UnityEngine.Playables;

public class EnterButton : MonoBehaviour
{
    public PlayableDirector timeline;
    public Animator animator;
    void Start()
    {
        Invoke("Pause", 5f);
       
    }

    void Pause()
    {
        timeline.Pause();
    }

    public void PlayTimeLine()
    {
        timeline.Play();
        Invoke("Kick", 15f);
    }

    public void Kick()
    {
        animator.Play("mixamo_com");
    }
}
