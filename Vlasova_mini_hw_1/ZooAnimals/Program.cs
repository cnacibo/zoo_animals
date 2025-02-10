using ZooAnimalsModel;

var veterinaryClinic = new VeterinaryClinic();
var zoo = new Zoo(veterinaryClinic);
var rabbit = new Rabbit(3, 5);
var tiger = new Tiger(9);
var monkey = new Monkey(8, 3);
    
zoo.AddAnimal(rabbit);
zoo.AddAnimal(tiger);
zoo.AddAnimal(monkey);

zoo.ShowFoodInformation();
zoo.ShowContactAnimals();
