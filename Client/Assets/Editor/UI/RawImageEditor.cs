﻿using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

 namespace RedStone.UI
{
    /// <summary>
    /// Editor class used to edit UI Images.
    /// </summary>
    [CustomEditor(typeof(RawImage), true)]
    [CanEditMultipleObjects]
    public class RawImageEditor : UnityEditor.UI.RawImageEditor
    {
    }
}
