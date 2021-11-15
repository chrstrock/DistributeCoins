using System;

namespace DistributeCoins
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Coins
    {
        public static int turns = 0;


        /// <summary>
        /// distributes coins across nodes
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int DistributeCoinsUtil(TreeNode root)
        {
            
            if (root == null)
                return 0;

            //go through left subtree
            int l = DistributeCoinsUtil(root.left);

            //iterate right subtree
            int r = DistributeCoinsUtil(root.right);

            //update moves
            turns += Math.Abs(l) + Math.Abs(r);

            return root.val + l + r -1;
        }

        public int DistributeCoins(TreeNode root)
        {
            DistributeCoinsUtil(root);
            return turns;
        }


    }
}
