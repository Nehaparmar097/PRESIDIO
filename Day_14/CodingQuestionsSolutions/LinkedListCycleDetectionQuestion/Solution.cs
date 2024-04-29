namespace LinkedListCycleDetectionQuestion
{

    // Defining for singlyl inked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        public static ListNode CreateLinkedList(int[] values)
        {
            if (values == null || values.Length == 0) return null;

            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            foreach (int val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummy.next;
        }

        public static async Task Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("Enter space-separated values for the linked list ");
            await Task.Delay(1000); // Simulate a delay of 1 second
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            int[] intValues = Array.ConvertAll(values, int.Parse);

            ListNode head = CreateLinkedList(intValues);

            Console.WriteLine("Does the linked list contain a cycle? (yes/no):");
            string hasCycleInput = Console.ReadLine().ToLower();

            if (hasCycleInput == "yes")
            {
                Console.WriteLine("Enter the value of the node to which the last node should be linked:");
                int linkValue = Convert.ToInt32(Console.ReadLine());

                ListNode linkNode = head;
                while (linkNode != null && linkNode.val != linkValue)
                {
                    linkNode = linkNode.next;
                }

                if (linkNode != null)
                {
                    ListNode lastNode = head;
                    while (lastNode.next != null)
                    {
                        lastNode = lastNode.next;
                    }
                    lastNode.next = linkNode;
                }
                else
                {
                    Console.WriteLine("Error: The specified value was not found in the linked list.");
                }
            }

            if (solution.HasCycle(head))
            {
                Console.WriteLine("The linked list contains a cycle.");
            }
            else
            {
                Console.WriteLine("The linked list does not contain a cycle.");
            }
        }
    }
}

