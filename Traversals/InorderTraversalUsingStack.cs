public static void InorderTraversal(Node root) {
	    
	    if (root == null) {
	        Console.WriteLine("Get the Fuck out of here!");
	    }
	    
	    
	     Stack<Node> s = new Stack<Node>();
	     
	     Node curr = root;
	     
	     while (curr!=null || s.Count>0){
	         
	         while(curr!=null){
	             s.Push(curr);
	             curr =  curr.left;
	         }
	         
	         curr = s.Pop();
	         
	         Console.Write(curr.val +" ");
	         
	        
	         curr = curr.right;
	        
	         
	         
	     }

        
	    
	}