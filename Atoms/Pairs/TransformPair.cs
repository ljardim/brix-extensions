using System;
using UnityEngine;

namespace UnityAtoms.Brix
{
    /// <summary>
    /// IPair of type `&lt;Transform&gt;`. Inherits from `IPair&lt;Transform&gt;`.
    /// </summary>
    [Serializable]
    public struct TransformPair : IPair<Transform>
    {
        public Transform Item1 { get => _item1; set => _item1 = value; }
        public Transform Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Transform _item1;
        [SerializeField]
        private Transform _item2;

        public void Deconstruct(out Transform item1, out Transform item2) { item1 = Item1; item2 = Item2; }
    }
}