using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Variable Inspector of type `Transform`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(TransformVariable))]
    public sealed class TransformVariableEditor : AtomVariableEditor<Transform, TransformPair> { }
}
