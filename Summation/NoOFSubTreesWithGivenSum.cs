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

		 root.left.left = new Node(7);

		  root.left.right = new Node(7);

		  root.right.left =new Node(-4);

		  root.right.right= new Node(7);


		 int res = 0;

		 int k =7;


		 NoOfSubTreeWithGivenSum(root, ref res, k);

		 Console.WriteLine(res);
	  	
		
	}


	public static int  NoOfSubTreeWithGivenSum(Node root, ref int res, int k){

		if (root== null){
			return 0;
		}

		int l = NoOfSubTreeWithGivenSum(root.left, ref res, k);
		int r = NoOfSubTreeWithGivenSum(root.right, ref res,  k);

		int currsum  = root.val+l+r;

		if (currsum ==  k){
			res = res+1;
		}

		return currsum;


	}


	



	
	// public static int Height (Node root) {
	// 	if (root ==null){
	// 		return 0;
	// 	}

	// 	return Math.Max(Height(root.left),Height(root.right))+1;
	// }


	

	


	
}


}
