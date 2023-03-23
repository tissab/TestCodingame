using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TreeNode
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode
                ( 6, 
                  new TreeNode(7, 
                        new TreeNode(2,new TreeNode(9)),new TreeNode(7, new TreeNode(1), new TreeNode(4))),
                  new TreeNode(8,new TreeNode(1), new TreeNode(3, new TreeNode(5))));

            var r = SumEventGrandparent(tree);
            Console.WriteLine("Hello World!");
        }

        static int SumEventGrandparent(TreeNode root)
        {
            if (root == null) return 0;
            int sum = 0;
            if (root.val % 2 == 0)
            {
                if (root.left != null && root.left.left != null)
                    sum += root.left.left.val;
                if (root.left != null && root.left.right != null)
                    sum += root.left.right.val;
                if (root.right != null && root.right.left != null)
                    sum += root.right.left.val;
                if (root.right != null && root.right.right != null)
                    sum += root.right.right.val;
            }
            sum += SumEventGrandparent(root.left);
            sum += SumEventGrandparent(root.right);
            return sum;
        }

      
        private static List<TreeNode> Traverse(TreeNode root)
        {
            if(root == null) return new List<TreeNode>();
            return Traverse(root.left).Concat(new[] { root }).Concat(Traverse(root.right)).ToList();
        }



    }


    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left = null, TreeNode right = null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

    }

}
