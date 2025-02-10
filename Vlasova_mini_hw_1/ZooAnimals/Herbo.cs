namespace ZooAnimalsModel;

public class Hebro : Animal {
    public int Kindness {get; set;}
    public Hebro(int kindness, int food){
        Food = food;
        Kindness = kindness > 0 && kindness < 10? kindness : 0;
    }
}