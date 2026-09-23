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

System.Console.WriteLine($"{roundTripMiles},{milesPerGallon},{pricePerGallon}"); //delete line once done testing

//Calculating cost
gallonsNeeded = roundTripMiles / milesPerGallon;
fuelCost = Convert.ToDecimal(gallonsNeeded) * pricePerGallon;

//Printing gasCalc Outputs
System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");