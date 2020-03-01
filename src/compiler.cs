
using System;
using System.Collections.Generic;
  
class MainClass {
   static string fileName = "index.spp";
   static string[] fileNameArr = fileName.Split(".");
   static string program_string = System.IO.File.ReadAllText(fileName);
   static string[] program = program_string.Split(';');

  public static void Main (string[] args) {

   if (File.Exists(fileName)) {
        File.Delete(fileName);
   } else {
      using (FileStream fs = File.Create(fileNameArr[0] + ".c"));   
   }
   new_line();
   
  }

  // start a new line
  static void new_line()
  {
   
}
}
