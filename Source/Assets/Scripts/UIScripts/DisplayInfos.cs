using TMPro;
using UnityEngine;

public class DisplayInfos : MonoBehaviour
{
    public TextMeshPro a1;
    public TextMeshPro a2;
    public TextMeshPro a3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GPManager.Level newLevel = new GPManager.Level();
        newLevel.Place = 1;
        newLevel.LevelName = "level1";
        newLevel.Time = 12f;

        GPManager.grandPrix[0] = newLevel;

        a1.text = $"Level :{GPManager.grandPrix[0].LevelName}";
        a2.text = $"Place : {GPManager.grandPrix[0].Place}";
        a3.text = $"Time :{GPManager.grandPrix[0].Time}";
    }

}
