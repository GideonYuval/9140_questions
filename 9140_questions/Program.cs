using System;
//using System.Collections.Generic;
using Unit4New;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9140_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        // 1
        // Return new list, without duplicates in param
        // param : Node<int>
        // return : Node<int>
        // example:
        // param : ->7,3,7,1,3 return : ->7,3,1
        // hint: first write bool isExist(Node<int> first, int num)

        static Node<int> RemoveDuplicates(Node<int> first)
        {
            return null;
        }

        // 2
        // Return new list, reverse of param
        // param : Node<int>
        // return : Node<int>
        // example:
        // param : ->1,2,3,4 return : ->4,3,2,1
        static Node<int> Reverse(Node<int> first)
        {
            return null;

        }

        //3
        // check if 2 lists are the equal
        // param : Node<int>, Node<int>
        // return : bool
        // example:
        // param1 : ->1,3,5,3,1 param2 : ->1,3,5,3,1  return : true
        // param1 : ->1,3,5,3,1 param2 : ->1,3,5,3,2  return : false
        // param1 : ->1,3,5,3,1 param2 : ->1,3,5,3,1,2  return : false

        static bool AreEqual(Node<int> a, Node<int> b)
        {
            return false;
        }


        //4
        // check if list is a Palindrom
        // param : Node<int>
        // return : bool
        // example:
        // param : ->1,3,5,3,1 return : true
        // param : ->1,3,5,2,1 return : false
        // hint : use Reverse(Node<int> first)

        static bool IsPalindrome(Node<int> first)
        {
            return false;
        }

        //5
        //return a list built from inputs (stop at input of -999)
        // param : void
        // return : Node<int>
        // example:
        // input : -999 return : null
        // input : 1,2,3,4 return : ->1,2,3,4
        // question : how many prompts (CW) did you use? can you do it in 1?
        static Node<int> Input2List()
        {
            return null;
        }

        //a different solution, which prompts only once
        static Node<int> Input2List_short()
        {
            return null;

        }

        //6
        // update list so the sum of 2 consecutive nodes equals the param we get
        // param1 : Node<int>, param2: int
        // return : void
        // example:
        // param1 : ->6,50,2,16 param2: 20, return : ->6,14,50,-30,2,18,16,4

        static void CouplesList(Node<int> lst, int num)
        {
    
        }

        //7
        // delete sequential duplicates in list
        // param1 : Node<int>
        // return : void
        // example:
        // param : ->5,6,6,6,10,10,5,5,8 return : ->5,6,10,5,8

        static void DeleteSeq(Node<int> list)
        {

        }

    }
}
