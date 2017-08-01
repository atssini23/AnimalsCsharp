namespace Animals{
    
    public class Animal{
        
        public int legs;
        public string name;
        public int weight;
        public double distance;

        public Animal(string nameString ){
            name = nameString;
            legs = 4;
            weight = 5;
            distance = 0.0;
        }
        public Animal(string nameString, int numLegs, int weightLb){
            name = nameString;
            legs = numLegs;
            weight = weightLb;
            distance = 0.0;

        }

        public void Move(double distanceTraveled){

            distance += distanceTraveled;

        }

        public void Speak(){
            System.Console.WriteLine("Hello, my name is {0}", name);
        }

    }
}