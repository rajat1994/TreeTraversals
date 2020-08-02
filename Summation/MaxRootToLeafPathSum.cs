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
	    
	    Node root = new Node(10);

		root.left = new Node(-2);
		root.right = new Node(7);
		root.left.left = new Node(8);
		root.left.right =new Node(-4);
		

		//int h = Height(root);

		

		int max  = 0;
		int  sum = 0;
		

		MaxRootToLeafPath(root,ref max,sum);

		
	    Console.WriteLine(max);
		

		
	    	
		
	}

	// public static int Height (Node root) {
	// 	if (root ==null){
	// 		return 0;
	// 	}

	// 	return Math.Max(Height(root.left),Height(root.right))+1;
	// }


	public static void MaxRootToLeafPath(Node root, ref int max, int sum ) {


		if (root == null){
			return ;
		}

		sum = sum+root.val;

		if(root.left == null && root.right == null) {

			

			max = Math.Max(sum,max);

		}

		MaxRootToLeafPath(root.left, ref max, sum);
		MaxRootToLeafPath(root.right, ref max, sum);


	}

	
	
}


}
