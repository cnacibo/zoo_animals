using ZooAnimalsModel;
using Microsoft.Extensions.DependencyInjection;

var veterinaryClinic = new VeterinaryClinic();
var zoo = AppConfig.Services.GetRequiredService<Zoo>();
var rabbit = new Rabbit(3, 5);
var tiger = new Tiger(9);
var monkey = new Monkey(8, 3);
var wolf = new Wolf(17);
    
zoo.AddAnimal(rabbit);
zoo.AddAnimal(tiger);
zoo.AddAnimal(monkey);
zoo.AddAnimal(wolf);

zoo.ShowFoodInformation();
zoo.ShowContactAnimals();
