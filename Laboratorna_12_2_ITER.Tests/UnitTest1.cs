namespace Laboratorna_12_2_ITER.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void TestRemoveByValue()
    {
        LinkedList list = new LinkedList();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(2);

        list.RemoveByValue(2);

        Assert.AreEqual("1 3 4 5 \n", GetPrintedLinkedList(list));
    }
    private string GetPrintedLinkedList(LinkedList list)
    {
        using (System.IO.StringWriter sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            list.Print();
            return sw.ToString();
        }
    }
}