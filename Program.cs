/*
 * Name: Dallas Sutton
 * Course: CSCI 1250, Section 001
 * Assignment: Lab 2, Trip Calculator
 * Date: September 23, 2026
 * Description: Prints a greeting and a short introduction to the console.
 */

// input variables for gasCalc
double roundTripMiles; 
double milesPerGallon;
decimal pricePerGallon;

//calculation and output variables for gasCalc
double gallonsNeeded;
decimal fuelCost;

//Reading gasCalc inputs

System.Console.Write("Round miles? ");
roundTripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Miles per gallon? ");
milesPerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Price per gallon? ");
pricePerGallon = Convert.ToDecimal(System.Console.ReadLine());

//Calculating cost
gallonsNeeded = roundTripMiles / milesPerGallon;
fuelCost = Convert.ToDecimal(gallonsNeeded) * pricePerGallon;

//Printing gasCalc Outputs
System.Console.WriteLine("");
System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");

// input variables for pizzaParty
int peopleAttending;
int pizzasNeeded;
decimal pricePerPizza;

//calculation and output variables for gasCalc
int totalSLices;
double slicePerPerson;
decimal totalPizzaCost;
const int SLICES_PER_PIZZA = 8;

//Reading pizzaParty inputs
System.Console.Write("How many people are attending? ");
peopleAttending = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("How many pizzas are being purchased? ");
pizzasNeeded = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Price per pizza? ");
pricePerPizza = Convert.ToDecimal(System.Console.ReadLine());

//Calculating cost
totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
slicePerPerson = totalSLices / peopleAttending;
totalPizzaCost = pizzasNeeded * pricePerPizza;

//Printing gasCalc Outputs
System.Console.WriteLine("");
System.Console.WriteLine($"Total slices: {totalSLices.ToString("")}");
System.Console.WriteLine($"Slices per person: {fuelCost.ToString("F2")}");
System.Console.WriteLine($"Pizza Cost: {totalPizzaCost.ToString("C")}");