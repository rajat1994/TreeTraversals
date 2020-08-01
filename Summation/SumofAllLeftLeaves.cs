using System;
using System.Collections.Generic; 

namespace Summation
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



public class InorderTraversalUsingStack{
    
	static public void Main (){
	    
	    Node root = new Node(4);
	    root.left = new Node(2);
	    root.right = new Node (5);
	    root.left.left = new Node(7);
	    root.left.right = new Node(2);
	    root.right.left = new Node (2);
	    root.right.right= new Node(3);
        root.right.right.left= new Node(38);
	    
	    int sum =0;
	    
	    SumOfAllLeftLeaves(root, ref sum);
	    
	    Console.WriteLine(sum);
	    
		
	}
	
	public static void SumOfAllLeftLeaves(Node root, ref int sum){
	    
	    if (root == null){
	        return;
	    }
	    
	    if (root.left != null ){
	        if (root.left.left == null && root.left.right == null){
	            sum = sum+root.left.val;
	           
	        }
	    }
	    
	    
	    SumOfAllLeftLeaves(root.left,ref sum);
	    SumOfAllLeftLeaves(root.right,ref sum);
	    
	}
	

	

	
}


}
