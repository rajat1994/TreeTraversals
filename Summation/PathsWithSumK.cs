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
	static public void Main (){
	    
	    Node root = new Node(1);

		 root.left = new Node(3);

		 root.right= new Node(-1);

		 root.left.left = new Node(2);

		 root.left.right =  new Node(1);

		 root.left.right.left = new Node(1);

		 root.right.left = new Node(4);

		 root.right.left.left = new Node(1);

		 root.right.left.right = new Node(2);

		 root.right.right = new Node(5);

		 root.right.right.right = new Node(6);

		


		 int k  = 5;

		

		

		 PathWithGivenSum(root, k);

		 

		

		
	    	
		
	}


	public static void PathWithGivenSum (Node root, int k) {

		if (root == null){
			return;
		}

		l.Add(root.val);

		PathWithGivenSum(root.left, k);

		PathWithGivenSum(root.right,k);

		int j =  0;


		for(int i = l.Count-1; i>=0;i--){
			j = j+l[i];

			if(j==k){

				printPath(l, i);
				Console.WriteLine();
				
				

				
			}
		}


		
		l.RemoveAt(l.Count-1);


	}

	public static void printPath (List<int> m, int j){

		for(int i =  j; i<l.Count;i++){
			Console.Write(l[i]+" ");
		}
	}


	



	
	// public static int Height (Node root) {
	// 	if (root ==null){
	// 		return 0;
	// 	}

	// 	return Math.Max(Height(root.left),Height(root.right))+1;
	// }


	

	


	
}


}
