using System;
namespace BinaryTreeSearch
{
	public class BinaryTree
	{
		public Node Root { get; set; }

		public bool Add(int value)
		{

			Node before = null, after = this.Root;

			while (after != null)
			{
				before = after;
				if (value < after.Data)
					after = after.LeftNode;
				else if (value > after.Data)
					after = after.RightNode;
				else
				{
					return false;
				}
			}
		
      
		Node newNode = new Node();
            newNode.Data=value;

            if(this.Root==null)
		   {
			this.Root = newNode;
		   }
		    else
			{
			   if (value < before.Data)
				before.LeftNode = newNode;
			   else
				before.RightNode = newNode;
		}
		    return true;
		}
		public void TransversPreOrder(Node Parent)
		{
			if (Parent != null)
			{
				Console.WriteLine(Parent.Data + " ");
				TransversPreOrder(Parent.LeftNode);
				TransversPreOrder(Parent.RightNode);

			}
		}
	}

}