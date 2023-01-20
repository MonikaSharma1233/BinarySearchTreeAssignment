namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree.");
            BinarySearchTree<int> binarysearch= new BinarySearchTree<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(70);
            binarysearch.Insert(22);
            binarysearch.Insert(40);
            binarysearch.Insert(60);
            binarysearch.Insert(95);
            binarysearch.Insert(11);
            binarysearch.Insert(65);
            binarysearch.Insert(3);
            binarysearch.Insert(16);
            binarysearch.Insert(63);
            binarysearch.Insert(67);
            bool result = binarysearch.IfExists(67, binarysearch);
            Console.WriteLine(result);
        }
    }
}
