using AlgoMania.ClassLibrary;
using AlgoMania.ClassLibrary.LinkedLists;

namespace AlgoMania.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void InsertFirstNodeToTail()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToTail(new Node("tail"));
            Assert.Equal("tail", linkedList.GetTail().Value);
        }

        [Fact]
        public void InsertFirstNodeToHead()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToHead(new Node("head"));
            Assert.Equal("head", linkedList.GetHead().Value);
        }

        [Fact]
        public void InsertTwoNodesToHead()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToHead(new Node("head2"));
            linkedList.InsertNodeToHead(new Node("head1"));
            Assert.Equal("head1", linkedList.GetHead().Value);
        }

        [Fact]
        public void InsertTwoNodesToTail()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToTail(new Node("tail2"));
            linkedList.InsertNodeToTail(new Node("tail1"));
            Assert.Equal("tail1", linkedList.GetTail().Value);
        }

        [Fact]
        public void InsertNodesToHeadAndTail()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToHead(new Node("head"));
            linkedList.InsertNodeToTail(new Node("tail"));
            Assert.Equal("head", linkedList.GetHead().Value);
            Assert.Equal("tail", linkedList.GetTail().Value);
        }

        [Fact]
        public void IsEmptyWithEmptyLinkedList()
        {
            var linkedList = new LinkedList();
            Assert.True(linkedList.IsEmpty());
        }

        [Fact]
        public void IsEmptyWithTwoNodes()
        {
            var linkedList = new LinkedList();
            linkedList.InsertNodeToHead(new Node("element"));
            linkedList.InsertNodeToHead(new Node("element2"));
            Assert.False(linkedList.IsEmpty());
        }
    }
}