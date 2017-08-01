namespace Animals{

    public class Dog : Animal{

        public int NumberOfSnacks = 3;
        public string Condition;
        public Dog(string nameString) : base(nameString){
            
            Condition = "Loved";
        }
        public Dog(string nameString, int numLegs, int weightLb) : base(nameString, numLegs, weightLb){

            Condition = "Unloved";
        }
        public void EatSnack(){
            System.Console.WriteLine("Im eating a snack...");
            NumberOfSnacks -= 1;
            System.Console.WriteLine("I have this {0} snaks left", NumberOfSnacks);
        }
        public new void Speak(){

            System.Console.WriteLine("Woof! My name is {0}", name);

        }




    }
}