//Керування автопарком
/*
public interface IVehicle
{
    void Start();
    void Stop();
    void Drive();
}

public class Car : IVehicle
{
    public string Model { get; set; }
    public Car(string model) { Model = model; }

    public void Start() => Console.WriteLine($"{Model} car started.");
    public void Stop() => Console.WriteLine($"{Model} car stopped.");
    public void Drive() => Console.WriteLine($"{Model} car is driving.");
}

public class Motorcycle : IVehicle
{
    public string Brand { get; set; }
    public Motorcycle(string brand) { Brand = brand; }

    public void Start() => Console.WriteLine($"{Brand} motorcycle started.");
    public void Stop() => Console.WriteLine($"{Brand} motorcycle stopped.");
    public void Drive() => Console.WriteLine($"{Brand} motorcycle is driving.");
}

public class Truck : IVehicle
{
    public int LoadCapacity { get; set; }
    public Truck(int loadCapacity) { LoadCapacity = loadCapacity; }

    public void Start() => Console.WriteLine($"Truck with capacity {LoadCapacity} tons started.");
    public void Stop() => Console.WriteLine($"Truck with capacity {LoadCapacity} tons stopped.");
    public void Drive() => Console.WriteLine($"Truck with capacity {LoadCapacity} tons is driving.");
}

public class Program
{
    public static void Main(string[] args)
    {
        IVehicle car1 = new Car("Toyota");
        IVehicle car2 = new Car("Honda");
        IVehicle motorcycle1 = new Motorcycle("Yamaha");
        IVehicle motorcycle2 = new Motorcycle("Harley-Davidson");
        IVehicle truck1 = new Truck(10);
        IVehicle truck2 = new Truck(20);

        IVehicle[] vehicles = { car1, car2, motorcycle1, motorcycle2, truck1, truck2 };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
            Console.WriteLine();
        }
    }
}
*/
//Менеджер завдань
/*
public interface ITask
{
    void Start();
    void Complete();
    string GetTaskInfo();
}

public class WorkTask : ITask
{
    public string Description { get; set; }
    public WorkTask(string description) { Description = description; }

    public void Start() => Console.WriteLine("Work task started.");
    public void Complete() => Console.WriteLine("Work task completed.");
    public string GetTaskInfo() => $"Work Task: {Description}";
}

public class PersonalTask : ITask
{
    public string Description { get; set; }
    public PersonalTask(string description) { Description = description; }

    public void Start() => Console.WriteLine("Personal task started.");
    public void Complete() => Console.WriteLine("Personal task completed.");
    public string GetTaskInfo() => $"Personal Task: {Description}";
}

public class StudyTask : ITask
{
    public string Subject { get; set; }
    public StudyTask(string subject) { Subject = subject; }

    public void Start() => Console.WriteLine("Study task started.");
    public void Complete() => Console.WriteLine("Study task completed.");
    public string GetTaskInfo() => $"Study Task: {Subject}";
}

public class Program
{
    public static void Main(string[] args)
    {
        ITask workTask = new WorkTask("Finish project");
        ITask personalTask = new PersonalTask("Buy groceries");
        ITask studyTask = new StudyTask("Study C# interfaces");

        ITask[] tasks = { workTask, personalTask, studyTask };

        foreach (var task in tasks)
        {
            Console.WriteLine(task.GetTaskInfo());
            task.Start();
            task.Complete();
            Console.WriteLine();
        }
    }
}
*/
//Керування бібліотекою книг
/*
public interface IPrintable
{
    void Print();
}

public interface IBorrowable
{
    void BorrowItem();
    void ReturnItem();
    bool IsAvailable();
}

public class Book : IPrintable, IBorrowable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    private bool available = true;