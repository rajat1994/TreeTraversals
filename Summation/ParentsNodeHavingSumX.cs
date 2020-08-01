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



public class InorderTraversalUsingStack{
    
	static public void Main (){
	    
	    Node root = new Node(4);
	    root.left = new Node(2);
	    root.right = new Node (5);
	    root.left.left = new Node(7);
	    root.left.right = new Node(2);
	    root.right.left = new Node (2);
	    root.right.right= new Node(3);

        int sum = 0;
	    
	    PrintParentOfGivenNode(root, 2, ref sum);

        Console.WriteLine(" ");

        Console.WriteLine(sum);
	    
	    
		
	}
	
	public static void  PrintParentOfGivenNode(Node root, int x, ref int sum ) {
	    if (root== null) {
	        return ;
	    }
	    
        if (root.left != null && root.left.val == x){

	        
            sum = sum+ root.val;
	        Console.Write(root.val + " ");

	    

        }

        else if (root.right != null && root.right.val ==x ) {


           sum = sum+root.val;
            
	        Console.Write(root.val + " ");
	    

        }
	    
	    PrintParentOfGivenNode(root.left,x, ref sum);
	    PrintParentOfGivenNode(root.right,x,ref sum);
	}
	

	
}
   

}
