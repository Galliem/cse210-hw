namespace foundation1;

class Comment:Video{
    public Comment():base(){}
    static List<string>comments;
    public void getV1Comments(){
        System.Console.WriteLine($"The first video has {cA1} comments.");
        if (comAmt1 != commentAmount1){
            System.Console.WriteLine("Enter a name for the first comment:");
            string name1 = Console.ReadLine();
            System.Console.WriteLine("Enter the text of the first comment:");
            string text1= Console.ReadLine();
            int commentAmount1 = comAmt1 + 1;
            comments.Add(name1+text1);
            System.Console.WriteLine($"{comments[0]}");
        }
            
        else
        {
            Console.WriteLine($"{comments}");
        }}
    public void getV2Comments(){
        System.Console.WriteLine($"The second video has {cA2} comments.");
        if (comAmt2 != commentAmount2){
            System.Console.WriteLine("Enter a name for the second comment:");
            string name2 = Console.ReadLine();
            System.Console.WriteLine("Enter the text of the second comment:");
            string text2 = Console.ReadLine();
            int commentAmount2 = comAmt2 + 1;
            comments.Add(text2);
            System.Console.WriteLine($"{comments[1]}");
        }
        else
        {
           System.Console.WriteLine($"{comments}"); 
        }}
    public void getV3Comments(){
        System.Console.WriteLine($"The third video has {cA3} comments.");
        if (comAmt3!= commentAmount3){
            System.Console.WriteLine("Enter a name for the third comment:");
            string writtenComment3 = Console.ReadLine();
            System.Console.WriteLine("Enter the text of the third comment:");
            string text3 = Console.ReadLine();
            int commentAmount3 = comAmt3 + 1;
            comments.Add(text3);
            System.Console.WriteLine($"{comments[2]}");
        }
        else
        {
            System.Console.WriteLine($"{comments}");
        }}
}

