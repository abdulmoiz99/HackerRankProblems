namespace HackerRankProblems.HashTable
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class TwoSumBST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var list = new List<int>();
            InOrderTraversal(root, list);
            int left = 0, right = list.Count() - 1;
            while (left < right)
            {
                int sum = list[left] + list[right];
                if (sum == k) return true;
                if (sum > k)
                    right--;
                else left++;
            }
            return false;

        }
        public void InOrderTraversal(TreeNode node, List<int> list)
        {
            if (node == null) return;
            InOrderTraversal(node.left, list);
            list.Add(node.val);
            InOrderTraversal(node.right, list);
        }

    }
}
