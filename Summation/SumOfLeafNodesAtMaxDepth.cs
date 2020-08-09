using System;
using System.Collections.Generic; 

namespace Traversals
{



public class Node {
    
    public Node left= null;
    public Node right = null;
    public int val = 0;
    
    public Node (int key) {
        this.left =null;
        this.right = null;
        this.val =  key;
    }
    
    
}



public class Program{
    

	 public static List<int> l = new List<int>();

	 public static int res = 0;
	static public void Main (){
	    
	    Node root = new Node(5);

		 root.left = new Node(-7);

		 root.right= new Node(3);

		 root.left.left = new Node(4);

		  root.left.right = new Node(5);

		  root.right.left =new Node(6);

		  root.right.right= new Node(-7);


		 int res = 0;

		 int h  = Height(root);


		 SumOfLeafNodesAtMaxDepth(root, ref res, h);

		 Console.WriteLine(res);
	  	
		
	}


	  public static void SumOfLeafNodesAtMaxDepth(Node root, ref int res , int h) {

		  if (root == null) {
			  return;
		  }

		  if (h == 1){

			  res = res+root.val;
		  }

		   SumOfLeafNodesAtMaxDepth(root.left, ref res, h-1);
		   SumOfLeafNodesAtMaxDepth(root.right, ref res, h-1);




	  }
	
	public static int Height (Node root) {
		if (root ==null){
			return 0;
		}

		return Math.Max(Height(root.left),Height(root.right))+1;
	}
	
}


}
