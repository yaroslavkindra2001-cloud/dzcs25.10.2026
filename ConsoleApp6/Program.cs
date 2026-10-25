using System;

class Website
{
    private string name;
    private string path;
    private string description;
    private string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Path
    {
        get { return path; }
        set { path = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public void Input()
    {
        Console.Write("Введите название сайта: ");
        Name = Console.ReadLine();

        Console.Write("Введите путь к сайту: ");
        Path = Console.ReadLine();

        Console.Write("Введите описание сайта: ");
        Description = Console.ReadLine();

        Console.Write("Введите адрес сайта: ");
        Address = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Название сайта: " + Name +
               "\nПуть к сайту: " + Path +
               "\nОписание сайта: " + Description +
               "\nАдрес сайта: " + Address;
    }
}

class Journal
{
    private string name;
    private int year;
    private string description;
    private string phone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void Input()
    {
        Console.Write("Введите название журнала: ");
        Name = Console.ReadLine();

        Console.Write("Введите год основания: ");
        Year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите описание журнала: ");
        Description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        Phone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        Email = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Название журнала: " + Name +
               "\nГод основания: " + Year +
               "\nОписание журнала: " + Description +
               "\nТелефон: " + Phone +
               "\nE-mail: " + Email;
    }
}

class Shop
{
    private string name;
    private string address;
    private string description;
    private string phone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void Input()
    {
        Console.Write("Введите название магазина: ");
        Name = Console.ReadLine();

        Console.Write("Введите адрес магазина: ");
        Address = Console.ReadLine();

        Console.Write("Введите описание профиля магазина: ");
        Description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        Phone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        Email = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Название магазина: " + Name +
               "\nАдрес магазина: " + Address +
               "\nОписание профиля: " + Description +
               "\nТелефон: " + Phone +
               "\nE-mail: " + Email;
    }
}

class Program
{
    static void Main()
    {
        Website website = new Website();
        Journal journal = new Journal();
        Shop shop = new Shop();

        Console.WriteLine(" Задание 1. Веб-сайт ");
        website.Input();
        Console.WriteLine("\n" + website);

        Console.WriteLine("\n Задание 2. Журнал ");
        journal.Input();
        Console.WriteLine("\n" + journal);

        Console.WriteLine("\n Задание 3. Магазин ");
        shop.Input();
        Console.WriteLine("\n" + shop);
    }
}