using System;
using System.Collections.Generic;
using System.IO;
class MainClass {
  //lineRunning is the line number that is running(lines start at 0)
  static int lineRunning = 0;
  //runningLine stores the value of the line that is running
  static string runningLine;
  // the name of the simplo++ source file
   static string fileName = "index.spp";
   //get the source code as a string
     static string program_string = System.IO.File.ReadAllText(fileName);
      //program is an array that stores each line as an array
      static string[] program;
  public static void Main (string[] args) {

   using (File.Create("index.c")) ;
   //split up each line into an element in an array
  program = program_string.Split(';');
  //get the value of the first line
   runningLine = program[lineRunning];
     //just set up the basic C file 
     File.AppendAllText("index.c", "#include<stdio.h>" + Environment.NewLine);

     File.AppendAllText("index.c", "int main(void) { " + Environment.NewLine);
   //new line
   new_line();
   
  }
  static void next_line() {
  
    if (lineRunning == program.Length - 1) {
      File.AppendAllText("index.c", "     ");
       File.AppendAllText("index.c", "return 0;" + Environment.NewLine);
        File.AppendAllText("index.c", "}" + Environment.NewLine);
      Console.WriteLine("compilation of simplo program sucsessful");
    } else {
      lineRunning += 1;
      runningLine = program[lineRunning];
      new_line();
    }
  }
  // start a new line
  static void new_line()
  {
   if (runningLine.Substring(0, 5) == "echo ") {
      runningLine = runningLine.Substring(5, runningLine.Length-5);
       File.AppendAllText("index.c", "printf(" + runningLine + "); " + Environment.NewLine);
       next_line();
   } else if(runningLine.Substring(0, 7) == "define ") {
      runningLine = runningLine.Substring(7, runningLine.Length-7);
      if (runningLine.Length > 7 && runningLine.Substring(0, 7) == "string ") {

       runningLine = runningLine.Substring(7, runningLine.Length-7);
       string[] runningLineString = runningLine.Split(" ");
       File.AppendAllText("index.c", "char " + runningLineString[0] + "[]" + " " + runningLineString[1]  + " " + runningLineString[2] + ";" + Environment.NewLine);
       next_line();
      } else if (runningLine.Length > 4 && runningLine.Substring(0, 4) == "int ") {

       runningLine = runningLine.Substring(3, runningLine.Length-3);
       string[] runningLineString = runningLine.Split(" ");
       File.AppendAllText("index.c", "char " + runningLineString[0] + "[]" + " " + runningLineString[1]  + " " + runningLineString[2] + ";" + Environment.NewLine);
       next_line();
      }
   }
          
   } 
}
