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
	    
	    Node root = new Node(5);

		root.left = new Node(2);
		root.right = new Node(4);
		root.left.left = new Node(1);
		root.left.right =new Node(5);
		root.left.right.left =new Node(0);
		root.left.right.right =new Node(5);

		int h = Height(root);

		

		int max  = 0;
		

		SumOfNodesOnLongestPath(root,h,0,0, ref max);

		
	    Console.WriteLine(max);
		

		
	    	
		
	}

	public static int Height (Node root) {
		if (root ==null){
			return 0;
		}

		return Math.Max(Height(root.left),Height(root.right))+1;
	}

	public static void SumOfNodesOnLongestPath(Node root, int h,  int pathen, int sum, ref int max) {
		if (root == null){
			return ;
		}

		sum = sum+root.val;
		
		pathen++;
		

		if (pathen == h) {
			max =Math.Max(max,sum);
			
		}


		SumOfNodesOnLongestPath(root.left,h,pathen,sum, ref max);
		SumOfNodesOnLongestPath(root.right,h,pathen,sum, ref max);

	}


	


	
}


}
