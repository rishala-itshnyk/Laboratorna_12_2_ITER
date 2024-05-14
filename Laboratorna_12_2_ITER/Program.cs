using System;

public class Node // Оголошення класу Node
{
    public int data; // Поле для збереження даних
    public Node next; // Вказівник на наступний елемент

    public Node(int value) // Конструктор класу Node
    {
        data = value;
        next = null;
    }
}

public class LinkedList // Оголошення класу LinkedList
{
    public Node head; // Поле для початкового вузла списку

    public void Add(int value) // Метод для додавання елементу до списку
    {
        Node newNode = new Node(value); // Створення нового вузла
        if (head == null) // Якщо список порожній
        {
            head = newNode; // Встановлення початкового вузла
        }
        else
        {
            Node current = head;
            while (current.next != null) // Пошук останнього вузла
            {
                current = current.next;
            }
            current.next = newNode; // Додавання нового вузла після останнього вузла
        }
    }

    public void Print() // Метод для виведення списку на екран
    {
        Node current = head;
        while (current != null) // Проходження по усіх вузлах списку
        {
            Console.Write(current.data + " "); // Виведення значення поточного вузла
            current = current.next; // Перехід до наступного вузла
        }
        Console.WriteLine(); // Виведення символу нового рядка після виведення всього списку
    }

    public void RemoveByValue(int value) // Метод для вилучення елементів із списку за заданим значенням
    {
        Node current = head;
        Node previous = null;

        while (current != null)
        {
            if (current.data == value)
            {
                if (previous == null) // Якщо поточний елемент - перший елемент списку
                {
                    head = current.next;
                }
                else
                {
                    previous.next = current.next;
                }
            }
            else
            {
                previous = current;
            }

            current = current.next;
        }
    }
}

public class Program // Оголошення класу Program
{
    static void Main(string[] args) // Основний метод програми
    {
        LinkedList list = new LinkedList(); // Створення нового списку

        // Додавання елементів до списку
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(2);

        Console.WriteLine("Список елементів:"); // Виведення тексту на екран
        list.Print(); // Виведення списку на екран

        Console.WriteLine("Введіть значення для вилучення зі списку: ");
        int valueToRemove = Convert.ToInt32(Console.ReadLine());

        list.RemoveByValue(valueToRemove); // Виклик методу для вилучення елементів із списку за заданим значенням

        Console.WriteLine($"Список після вилучення елементів за значенням {valueToRemove}:"); // Виведення тексту на екран
        list.Print(); // Виведення списку на екран

        Console.ReadLine(); // Очікування натискання клавіші Enter перед завершенням програми
    }
}
