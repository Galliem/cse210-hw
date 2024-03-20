namespace GoalProject;
using System.IO;

public class SaveLoad:Goal{
    public SaveLoad(){}

    public void SaveLoadGoal(){
        System.Console.WriteLine($"{goalList}");
    }
    // public void fileWork(){
    //     string filename = "myFile.txt";
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines){
    //         string[] parts = line.split(DELIMITER);
    //         string goal = parts[0];
    //         points = parts[1];
    //     }

    //     using(StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         outputFile.WriteLine("First line in file.");
    //         string color = "Blue";
    //         outputFile.WriteLine($"My favorite color is {color}");
    //     }
    // }
    public List<string> GetStringRep(){
         List<string> repGoal = goalList;
         return repGoal; }
}