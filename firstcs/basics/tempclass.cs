using System;

namespace Tempclass {
     class Station {
        // variables
        public string[] sName = new string[5];
        public string[] sID = new string[5];
        
        public Station() { // constructor
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter station ID: ");
                sID[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++) {
                Console.Write("Enter station name: ");
                sName[i] = Console.ReadLine();
            }
        }
    }

    class Temperature {
        // variables
        public double[] celsius = new double[5];
        public double[] fahrenheit = new double[5];
        public double avg;
        
        public Temperature() { // constructor
            double sum = 0.0;
            for(int i = 0; i < 5; i++) {
                Console.Write("Enter temperature in Fahrenheit: ");
                fahrenheit[i] = Convert.ToDouble(Console.ReadLine());
                celsius[i] = (fahrenheit[i] - 32) * 5 / 9;
                sum = sum + celsius[i];
            }
            avg = sum / 5;
        }
    }

    public class tempclass {
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
            Station sta = new Station();
            Temperature temp = new Temperature();
            string dfavg = temp.avg.ToString("#.00");
            /*determine max and min rows.
            * System will determine the max and min temperatures first,
            * then search for all stations with that max/min temps.
            */
            double maxTemp = temp.celsius[0];
            double minTemp = temp.celsius[0];
            List<string> maxName = new List<string>();
            List<string> minName = new List<string>();
            List<string> maxID = new List<string>();
            List<string> minID = new List<string>();
            List<int> maxIndex = new List<int>();
            List<int> minIndex = new List<int>();
            for (int m = 0; m < 5; m++) {
                if (temp.celsius[m] > maxTemp) {
                    maxTemp = temp.celsius[m];
                }
                if (temp.celsius[m] < minTemp) {
                    minTemp = temp.celsius[m];
                }
            }
            for (int n = 0; n < 5; n++) {
                if (temp.celsius[n] == maxTemp) {
                    maxID.Add(sta.sID[n]);
                    maxName.Add(sta.sName[n]);
                    maxIndex.Add(n);
                }
                if (temp.celsius[n] == minTemp) {
                    minID.Add(sta.sID[n]);
                    minName.Add(sta.sName[n]);
                    minIndex.Add(n);
                }
            }
            //final report, and search
            fullReport(sta.sID, sta.sName, temp.celsius);
            tempReport(maxTemp, minTemp, maxID, minID, maxIndex, minIndex, maxName, minName, dfavg);
            search(sta.sID, sta.sName, temp.fahrenheit, temp.celsius);
        }
    }
}
