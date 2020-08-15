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

	 public static int sum = 0;
	static public void Main (){


		Node root = new Node(1);
		root.left = new Node(2);
		root.right =  new Node(3);
		root.left.left = new Node(4);
		root.right.right = new Node(90);
		root.left.right = new Node(5);
		root.left.right.left = new Node(8);
		root.right.left = new Node(6);
		root.right.left.right = new Node(9);


		 int res = 1000;
		 int count = 1;
		 


		 HeightOfLeavesAtMinLevel(root, ref res, count);

		 //Console.WriteLine(res);

		 SumAtMinLevelLeaves(root, res);

		 Console.WriteLine(sum)
		
	}


	public static  void HeightOfLeavesAtMinLevel(Node root, ref int res, int count) {


		if (root == null){
			return;
		}

		if (root.left==null && root.right == null){

			res = Math.Min(res,count);
		}


		 HeightOfLeavesAtMinLevel(root.left,ref res, count+1);
		 HeightOfLeavesAtMinLevel(root.right,ref  res, count+1);



	}


	public static void SumAtMinLevelLeaves(Node root, int level) {
		if (root == null){

                return;

		}

		if (level==1 && root.right == null && root.left == null){
			sum = sum+root.val;
		}


          SumAtMinLevelLeaves(root.left, level-1);
		  SumAtMinLevelLeaves(root.right,level-1);





	}

	
}


}
