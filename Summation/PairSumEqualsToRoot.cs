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

		bool a = false;

		for(int i = 2; i<=h;i++){

		   List<int> d =new List<int>();

		   if ( PairSumEqualsToRootData(root,i,d, root.val)==true){
			   a=true;
			   break;
		   }

		}

		Console.WriteLine(a);
	    	
		
	}


	public static int Height (Node root) {
		if (root ==null){
			return 0;
		}

		return Math.Max(Height(root.left),Height(root.right))+1;
	}


	public static bool PairSumEqualsToRootData(Node root,int i,List<int> d, int key) {

		if (root== null){
			return false;
		}


		if (i == 1) {
			if (d.Contains(root.val)){
				return true;
			}

			else{
				d.Add(key-root.val);
				return false;
			}
		}

		return PairSumEqualsToRootData(root.right,i-1,d, key) || PairSumEqualsToRootData(root.left,i-1,d, key);

	}


	
}


}
