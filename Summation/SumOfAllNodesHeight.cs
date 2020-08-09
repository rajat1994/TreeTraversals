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
	    
	    Node root = new Node(1);

		 root.left = new Node(3);

		 root.right= new Node(-1);

		 root.left.left = new Node(2);

		  root.left.right = new Node(5);


		 SumOfHeights(root);

		 Console.WriteLine(res);

	  	
		
	}


	public static int SumOfHeights(Node root) {

		if (root == null) {
			return 0;
		}

		int l = SumOfHeights(root.left);

		int r =  SumOfHeights(root.right);

		int Ht =  Math.Max(l,r)+1;

		res = res + Ht;

		return Ht;

		
	}



	
	// public static int Height (Node root) {
	// 	if (root ==null){
	// 		return 0;
	// 	}

	// 	return Math.Max(Height(root.left),Height(root.right))+1;
	// }


	

	


	
}


}
