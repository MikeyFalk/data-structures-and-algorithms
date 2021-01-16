using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTest
  {
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_A_Head()
    {
      int value = 2;
      LinkedList testList = new LinkedList(value);
      Assert.Equal(value, testList.Head.Value);

    }

    [Fact]
    public void After_Insert_New_Node_Is_The_Head()
    {
      LinkedList testList = new LinkedList(5);
      //H(5) -> NULL

      testList.Insert(10);
      // H(10) -> 5 ->Null
      Assert.Equal(10, testList.Head.Value);

    }

    [Fact]
    public void After_Insert_Head_Bext_Is_The_Old_Head()
    {
      LinkedList testList = new LinkedList(5);
      Node oldHead = testList.Head;

      testList.Insert(10);

      Assert.Equal(oldHead, testList.Head.Next);
    }
    [Fact]

    public void Check_To_See_If_Value_Is_In_List()
    {
      LinkedList testList = new LinkedList(6);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);


      Assert.True(testList.Includes(4));

    }
    [Fact]
    public void Check_To_See_If_Value_Is__Not_In_List()
    {
      LinkedList testList = new LinkedList(6);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);


      Assert.False(testList.Includes(10));

    }
    [Fact]
    public void Check_Strings()
    {
      LinkedList testList = new LinkedList(1);
      string testingString = "[1] => [2] => [5] => null";
      testList.Insert(2);
      testList.Insert(5);
      Assert.Equal(testingString, testList.Print());

    }

    [Fact]
    public void Check_Empty_List()
    {
      LinkedList testList = new LinkedList();
      Assert.Null(testList.Head);
    }
  }
}  

