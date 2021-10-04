using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AVLTree.Models.WordCount
{
    /// <summary>
    /// Balance state of an AVLTree
    /// </summary>
    public enum TreeState
    {
        LeftHeavy,
        RightHeavy,
        Balanced
    }
}