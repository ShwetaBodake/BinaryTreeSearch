
using BinaryTreeSearch;

namespace BinaryTreeSearch
{
}
public class Program
{
public static void Main(string[] args)
    {
        BinaryTree binaryTree = new BinaryTree();
        binaryTree.Add(20);
        binaryTree.Add(90);
        binaryTree.Add(40);
        binaryTree.Add(20);
        binaryTree.Add(40);
        binaryTree.Add(24);

        binaryTree.TransversPreOrder(binaryTree.Root);

    }
}
