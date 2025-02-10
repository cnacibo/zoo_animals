namespace ZooAnimalsModel;

public class Zoo{
    private readonly LinkedList<Animal> animals = new LinkedList<Animal>();
    private readonly LinkedList<IInventory> inventory = new LinkedList<IInventory>();
    private readonly VeterinaryClinic _veterinaryClinic;

    public Zoo(VeterinaryClinic veterinaryClinic)
    {
        _veterinaryClinic = veterinaryClinic;
    }

    public void AddAnimal(Animal animal){
        if (_veterinaryClinic.CheckAnimalHealth(animal)){
            animals.AddLast(animal);
            Console.WriteLine($"Животное {animal.GetType().Name} добавлено в зоопарк.");
        } 
        else{
            Console.WriteLine($"Животное {animal.GetType().Name} не прошло проверку здоровья и не принято в зоопарк.");
        }

    }
    public void ShowFoodInformation(){
        Console.WriteLine("\nИнформация о необходим количестве еды в день для животных:");
        foreach (Animal animal in animals){
            Console.WriteLine($"Животное {animal.GetType().Name}. Еда в день: {animal.Food} кг.");
        }
    }
    public void ShowContactAnimals(){
        Console.WriteLine("\nИнформация о животных, которые могут быть отправлены в контактный зоопарк:");
        foreach (Animal animal in animals){
           if (animal is Hebro herbo && herbo.Kindness > 5){
                Console.WriteLine($"Животное {animal.GetType().Name}");
           }
        }
    }
    public void ShowInventory()
    {
        Console.WriteLine("\nИнформация о предметах в зоопарке:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"Предмет: {item.GetType().Name}. Инвентаризационный номер: {item.Number}\n");
        }
    }
}