Console.WriteLine("how many eggs did homies collect today?");
int eggs = Convert.ToInt32(Console.ReadLine());
int sisters = eggs / 4;
int duckbear = eggs % 4;
Console.WriteLine($"The duckbear will get {duckbear} eggs, and the sisters will get {sisters} eggs each");
// the total numbers where the sisters will get less than the duckbear are 1, 2 and 3.