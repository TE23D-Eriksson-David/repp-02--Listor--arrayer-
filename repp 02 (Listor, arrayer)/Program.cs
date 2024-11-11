using SC = System.Console;

string [] Leksaker = ["Apa", "Brandbil", "Sopbil", "Nalle", "Pappa"];

for (int i = 0; i < Leksaker.Length; i++)
{
   SC.WriteLine(Leksaker[i]); 
}

string [] Klasskamrater = ["Ludvig","Jacob","Simon","Imad","Theodor"];
int[] Numer = [1,3,5,7,9];

for (int i = 0; i < Numer.Length; i++)
{
    SC.WriteLine($"{Klasskamrater[i]} ger {Leksaker[i]} betyget {Numer[i]}."); 
}

List<string> cities = new List<string>(); 
string input_str = "";

SC.WriteLine("write thing to add to cities list, type exit to exit");
while (true){
input_str = SC.ReadLine().ToLower();
if (input_str == "exit"){
    break;
}
cities.Add(input_str);
}

for (int i = 0; i < cities.Count; i++)
{
    SC.WriteLine(cities[i]);
}

SC.ReadLine();