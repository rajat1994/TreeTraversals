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

		 root.right= new Node(6);

		 root.left.left = new Node(5);

		  root.left.right = new Node(9);

		  root.right.left =new Node(8);


		 bool res = false;

		 int k =14;


		 SubTreeWithGivenSum(root, ref res, k);

		 Console.WriteLine(res);
	  	
		
	}


	public static int  SubTreeWithGivenSum(Node root, ref bool res, int k){

		if (root== null){
			return 0;
		}

		int l = SubTreeWithGivenSum(root.left, ref res, k);
		int r = SubTreeWithGivenSum(root.right, ref res,  k);

		int currsum  = root.val+l+r;

		if (currsum ==  k){
			res = true;
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
