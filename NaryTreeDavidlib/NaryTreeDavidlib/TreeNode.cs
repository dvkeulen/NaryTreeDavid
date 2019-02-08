using System;
using System.Collections.Generic;
namespace NaryTreeDavid
{
    public class TreeNode<T>
    {
        public T value;
        public TreeNode<T> parent;
        public List<TreeNode<T>> children;

        public TreeNode(T ivalue,TreeNode<T> iparent)
        {
            value = ivalue;
            parent = iparent;
        }


    }
}