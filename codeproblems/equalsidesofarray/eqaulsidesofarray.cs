/*description


You are going to be given an array of integers. Your job is to take that array and find an index N where the sum of the integers to the left of N is equal to the sum of the integers to the right of N. If there is no index that would make this happen, return -1.

For example:

Let's say you are given the array {1,2,3,4,3,2,1}:
Your function will return the index 3, because at the 3rd position of the array, the sum of left side of the index ({1,2,3}) and the sum of the right side of the index ({3,2,1}) both equal 6.

Let's look at another one.
You are given the array {1,100,50,-51,1,1}:
Your function will return the index 1, because at the 1st position of the array, the sum of left side of the index ({1}) and the sum of the right side of the index ({50,-51,1,1}) both equal 1.

Last one:
You are given the array {20,10,-80,10,10,15,35}
At index 0 the left side is {}
The right side is {10,-80,10,10,15,35}
They both are equal to 0 when added. (Empty arrays are equal to 0 in this problem)
Index 0 is the place where the left side and right side are equal.

Note: Please remember that in most programming/scripting languages the index of an array starts at 0.

Input:
An integer array of length 0 < arr < 1000. The numbers in the array can be any integer positive or negative.

Output:
The lowest index N where the side to the left of N is equal to the side to the right of N. If you do not find an index that fits these rules, then you will return -1.

Note:
If you are given an array with multiple answers, return the lowest correct index.

*/

using System.Linq;

public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int leftSum = 0, rightSum = arr.Sum();

        for (int i = 0; i < arr.Length; ++i)
        {
            rightSum -= arr[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += arr[i];
        }

        return -1;
    }
}

/*

test cases

using NUnit.Framework; 
using System.Collections.Generic;
using System.Linq;
using System;
[TestFixture]
public class ValidateWordTest
{
  [Test]
  public void GenericTests()
  {
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {1,2,3,4,3,2,1}), "The array was: {1,2,3,4,3,2,1}");
    Assert.AreEqual(1,Kata.FindEvenIndex(new int[] {1,100,50,-51,1,1}), "The array was: {1,100,50,-51,1,1}");
    Assert.AreEqual(-1,Kata.FindEvenIndex(new int[] {1,2,3,4,5,6}), "Remember to return -1 if there isn't an index that will work.");
    Assert.AreEqual(3,Kata.FindEvenIndex(new int[] {20,10,30,10,10,15,35}), "The array was: {20,10,30,10,10,15,35}");
    Assert.AreEqual(-1, Kata.FindEvenIndex(new int[] {8, 8}));
    Assert.AreEqual(0, Kata.FindEvenIndex(new int[] {8, 0}));
    Assert.AreEqual(1, Kata.FindEvenIndex(new int[] {0, 8}));
    Assert.AreEqual(0, Kata.FindEvenIndex(new int[] {7, 3, -3}));
    Assert.AreEqual(0, Kata.FindEvenIndex(new int[] {8}));
  }
  //----------------------
  private static int FindEvenIndexT(int[] arr)
    {
        List<int> list = new List<int>(arr);
        for (int i = 0; i < list.Count; i++)
        {
            List<int> list1 = list.Take(i).ToList();
            List<int> list2 = list.Skip(i+1).Take(list.Count - i).ToList();
            if (list1.Sum() == list2.Sum())
            {
                return i;
            }
        }
        return -1;
    }
  //----------------------
  [Test]
  public static void RandomStringTests(){
      Console.WriteLine("\n ********** 50 Random Tests **********");
      Random rnd = new Random();
      
      for (int i = 0; i < 50; i++) {
        int trueOrFalse = rnd.Next(1,3);
        int index= 0;
        List<int> output = new List<int>();
        int rando = rnd.Next(2,500);
        for(int j = 0; j<rando; j++)
        {
          int n = rnd.Next(-10000, 10000);
          output.Add(n);
        }
        if(trueOrFalse == 1)
        { 
          index = rnd.Next(1,output.Count);
          List<int> list1 = output.Take(index).ToList();
          List<int> list2 = output.Skip(index+1).Take(output.Count - index).ToList();
          output.Add(list1.Sum() - list2.Sum());
        }
        Assert.AreEqual(FindEvenIndexT(output.ToArray()), Kata.FindEvenIndex(output.ToArray()), "The failed array was: " +string.Join(",", output));
      }
    }
}
*/