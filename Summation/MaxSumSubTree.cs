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
    
	static public void Main (){
	    
	    Node root = new Node(1);

		 root.left = new Node(-2);

		 root.right= new Node(3);

		 root.left.left = new Node(-4);

		 root.left.right = new Node(-5);

		 root.right.left = new Node(6);

		 root.right.right = new Node(2);


		 int res  = 0;

		 MaxSumSubTree(root, ref res);

		 Console.WriteLine(res);

		

		
	    	
		
	}


	public static void MaxSumSubTree(Node root, ref int res) {

         if (root == null){
			 return ;
		 }

		 int sum = SumSubTree(root);

		 res = Math.Max(res,sum);


		 MaxSumSubTree(root.left, ref res);

		 MaxSumSubTree(root.right,ref res);


	}

	public static int SumSubTree(Node root) {

		if (root == null){
			return 0;
		}

		return root.val + SumSubTree(root.left) + SumSubTree(root.right);
	}





	
	// public static int Height (Node root) {
	// 	if (root ==null){
	// 		return 0;
	// 	}

	// 	return Math.Max(Height(root.left),Height(root.right))+1;
	// }


	

	


	
}


}
