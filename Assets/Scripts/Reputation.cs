using TMPro;
using UnityEngine;
using System.Collections;


public class Reputation : MonoBehaviour
{
    public string reputation;
    public ParticleSystem ps;
    public bool levelUp;
    public float nextLevel;
    public float currentEXP;
    public int level;
    public float EXPraise;
    public int LastLevel;

    [SerializeField] Animator textAnimator;
    [SerializeField] float endAnimationTimer = 5f;

    [SerializeField]
    private string[] reputationTitles;

    [SerializeField]
    private GameObject[] reputationImages;

    [SerializeField]
    private TextMeshProUGUI reputationText;
    public void Start()
    {
        // ps = GetComponentInChildren<ReputationLevelUp>();
        reputationImages[level].SetActive(true);
        PlayAnimation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // UpdateReputation((int)Treasure.treasureValue/reputationTitles.Length);
        if (reputation != reputationTitles[LastLevel])
        {
        reputation = reputationTitles[level + 1];
        }
        currentEXP = Treasure.treasureValue;
        if (currentEXP >= nextLevel)
        {
            ps.Play(true);
            UpdateReputation();
        }

    }
    public void UpdateReputation()
    {
        reputationImages[level].SetActive(false);
        level = level + 1;
        reputationImages[level].SetActive(true);
        reputationText.text = reputation;
        nextLevel = nextLevel + EXPraise;
        PlayAnimation();
    }

    public void PlayAnimation()
    {
        textAnimator.Play("ReputaionText_Slide_In");
        StartCoroutine(endAnimation(endAnimationTimer));

    }

    IEnumerator endAnimation(float time)
    {
        yield return new WaitForSeconds(time);
        textAnimator.SetTrigger("End");
    }
 
}
