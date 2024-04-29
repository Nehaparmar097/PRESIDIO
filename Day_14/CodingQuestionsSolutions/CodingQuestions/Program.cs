namespace CodingQuestions
{
    internal class Program
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

        public class Solution
        {
            public async Task<int> MinDepthAsync(TreeNode root)
            {
                if (root == null) return 0;
                if (root.left == null && root.right == null) return 1;

                int l = int.MaxValue, r = int.MaxValue;
                if (root.left != null)
                    l = await MinDepthAsync(root.left);
                if (root.right != null)
                    r = await MinDepthAsync(root.right);

                return 1 + Math.Min(l, r);
            }

            public static async Task Main(string[] args)
            {
                Solution solution = new Solution();

                // Example usage:
                TreeNode root = new TreeNode(3);
                root.left = new TreeNode(9);
                root.right = new TreeNode(20);
                root.right.left = new TreeNode(15);
                root.right.right = new TreeNode(7);

                int minDepth = await solution.MinDepthAsync(root);
                Console.WriteLine("Minimum depth of the tree: " + minDepth);
            }
        }
    }
}

