const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

int numberOfSandwiches;
int numberOfToppings;
double tip;

Console.WriteLine("Please enter number of sandwiches: ");
numberOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of toppings needed: ");
numberOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter tip amount, expressed as a decimal: ");
tip = double.Parse(Console.ReadLine());

double totalSandwichCost = 0;
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

double totalToppingCost = 0;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;

double baseCost = 0;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = 0;
orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

Console.WriteLine("Your total order cost is : " + orderCost);
