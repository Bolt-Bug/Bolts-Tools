using System;
using BoltsTools;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoltsToolsDemo : MonoBehaviour
{
    [BoltsComment("This String Has A Comment")]
    public string comment = "There Is A Comment Above Me";

    public InputActionAsset iaa;
    [BoltsInputAction("iaa")]
    public string inputAction;

    public Animator ani;
    [BoltsAnimationClip("ani")]
    public string animationClip;
    [BoltsAnimationParam("ani")]
    public string animationParam;

    [BoltsToolTip("This Is A Tool Tip")]
    public string toolTip = "This String Has A Tool Tip";

    public Material mat;
    [BoltsShaderProperty("mat")]
    public string material;

    [BoltsSave(SavedVariableType.Any, 0)]
    public string savedString;
    
    void Start() =>
        BoltsCommands.AddCommand("DemoMove", () => BoltsDebugMenu.Instance.player.transform.position = Vector3.one,
            "Moves The Player");
}
