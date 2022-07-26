﻿using System;

namespace Basics {
    class temparray {

        static string[] getID() {
            string[] input = new string[5];
            Console.WriteLine("-------Input of Station ID--------");
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter station ID " + (i + 1) + ": ");
                input[i] = Console.ReadLine();
            }
            return input;
        }

        static string[] getName(string[] sID) {
            string[] input = new string[5];
            Console.WriteLine("\n-------Input of Station Name-------");
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter station name for " + sID[i] + ": ");
                input[i] = Console.ReadLine();
            }
            return input;
        }

        static double[] getTemp(string[] sName) {
            double[] input = new double[5];
            Console.WriteLine("\n-----Input of Temperature in Fahrenheit-----");
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter temperature of " + sName[i] + ": ");
                input[i] = Convert.ToDouble(Console.ReadLine());
            }
            return input;
        } //end of input methods

        //calculation method getCelsius(), getAvg()
        static double[] getCelsius(double[] frh) {
            double[] cels = new double[5];
            for (int i = 0; i < 5; i++) {
                cels[i] = (frh[i] - 32) * 5 / 9;
            }
            return cels;
        }

        static double getAvg(double[] cels) {
            double avg, sum = 0;
            for (int i = 0; i < 5; i++) {
                sum = sum + cels[i];
            }
            avg = sum / 5;
            return avg;
        } //end of calculation methods

        static void fullReport(string[] sID, string[] sName, double[] cels) {
            string[] dfcels = new string[5];
            for (int j = 0; j < 5; j++) {
                dfcels[j] = cels[j].ToString("#.00"); ; //format celsius to 2 d.p.
            }
            Console.WriteLine("\n----------------Input Summary---------------------");
            //{} style is used so table is padded and columns are aligned
            Console.WriteLine("{0,-10} {1,-18} {2,-5}", "ID", "Name", "Temperature (C)");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("{0,-10} {1,-18} {2,-5}", sID[i], sName[i], dfcels[i]);
            }
        }

        static void tempReport(double maxTemp, double minTemp, List<string> maxID, List<string> minID,
                        List<int> maxIndex, List<int> minIndex, List<string> maxName,
                        List<string> minName, string dfavg) {
            //formatting decimal places
            string dfmax = maxTemp.ToString("#.00");
            string dfmin = minTemp.ToString("#.00");
            //outputs
            Console.WriteLine("\n---------------Temperature Report------------------");
            Console.WriteLine("Average temperature is: " + dfavg + " Celsius.");

            Console.WriteLine("\nStations with maximum temperatures: ");
            Console.WriteLine("{0,-7} {1,-10} {2, -18} {3,-5}", "Index", "ID", "Name", "Celsius");
            for (int i = 0; i < maxID.Count; i++) {
                Console.WriteLine("{0,-7} {1,-10} {2, -18} {3,-5}", maxIndex[i], maxID[i], maxName[i], dfmax);
            }
            Console.WriteLine("\nStations with minimum temperatures: ");
            Console.WriteLine("{0,-7} {1,-10} {2, -18} {3,-5}", "Index", "ID", "Name", "Celsius");
            for (int j = 0; j < minID.Count; j++) {
                Console.WriteLine("{0,-7} {1,-10} {2, -18} {3,-5}", minIndex[j], minID[j], minName[j], dfmin);
            }
        } //end tempReport()

        static void search(string[] stationID, string[] stationName, double[] fahrenheit, double[] celsius) {
            Console.WriteLine("\n======= Station ID Search =======");
            string yesno = "";
            string target;
            do {
                do { //this loop verifies that user wants to search. if "N" is inputted, the program will end immediately.
                    Console.Write("\nSearch by station ID? (Y/N): ");
                    yesno = Console.ReadLine();
                    if (yesno == "N") {
                        Console.WriteLine("OK. System will exit now.");
                        Console.WriteLine("All temperatures processed.");
                        Environment.Exit(0);
                    } else if (yesno == "Y") {
                        continue;
                    } else {
                        Console.WriteLine("Invalid input! Please input \"Y\" or \"N\" only.");
                    }
                } while (!(yesno == "Y" || yesno == "N"));
                //var initialisations
                int tgtIndex;
                string tgtID, tgtName;
                double tgtCels, tgtFahr;
                //search algorithm
                Console.Write("Enter station ID to search: ");
                target = Console.ReadLine();
                bool found = false;
                for (int n = 0; n < 5; n++) {
                    if (stationID[n] == target) {
                        tgtCels = celsius[n];
                        tgtFahr = fahrenheit[n];
                        tgtID = stationID[n];
                        tgtName = stationName[n];
                        tgtIndex = n;
                        found = true;
                        string dftgtCels = tgtCels.ToString("#.00");
                        string dftgtFahr = tgtFahr.ToString("#.00");
                        Console.WriteLine("Target found. Displaying.....");
                        Console.WriteLine("{0,-7} {1,-10} {2,-18} {3,-10} {4,-10}", "Index", "ID", "Name", "Fahrenheit", "Celsius");
                        Console.WriteLine("{0,-7} {1,-10} {2,-18} {3,-10} {4,-10}", tgtIndex, tgtID, tgtName, dftgtFahr, dftgtCels);
                    }
                }
                if (!found) {
                    Console.WriteLine("No record for station ID " + target + " found. Please search again.");
                }
            } while (true); //loops back to line 126. 
                            //This is not considered an infinite loop as it contains a program-ending sentinel value "N".
        } //end search()

        static void xMain(string[] args) {
            string[] stationID = new string[5];
            string[] stationName = new string[5];
            double[] fahrenheit = new double[5];
            double[] celsius = new double[5];
            //obtain inputs via methods, and conversion of F to C temperatures
            stationID = getID();
            stationName = getName(stationID);
            fahrenheit = getTemp(stationName);
            celsius = getCelsius(fahrenheit);
            //calculate average
            double average = getAvg(celsius);
            string dfavg = average.ToString("#.00");
                /*determine max and min rows.
                * System will determine the max and min temperatures first,
                * then search for all stations with that max/min temps.
                */
                double maxTemp = celsius[0];
                double minTemp = celsius[0];
                List<string> maxName = new List<string>();
                List<string> minName = new List<string>();
                List<string> maxID = new List<string>();
                List<string> minID = new List<string>();
                List<int> maxIndex = new List<int>();
                List<int> minIndex = new List<int>();
                for (int m = 0; m < 5; m++) {
                    if (celsius[m] > maxTemp) {
                        maxTemp = celsius[m];
                    }
                    if (celsius[m] < minTemp) {
                        minTemp = celsius[m];
                    }
                }
                for (int n = 0; n < 5; n++) {
                    if (celsius[n] == maxTemp) {
                        maxID.Add(stationID[n]);
                        maxName.Add(stationName[n]);
                        maxIndex.Add(n);
                    }
                    if (celsius[n] == minTemp) {
                        minID.Add(stationID[n]);
                        minName.Add(stationName[n]);
                        minIndex.Add(n);
                    }
                }
            //final report, and search
            fullReport(stationID, stationName, celsius);
            tempReport(maxTemp, minTemp, maxID, minID, maxIndex, minIndex, maxName, minName, dfavg);
            search(stationID, stationName, fahrenheit, celsius);
        }
    }
}