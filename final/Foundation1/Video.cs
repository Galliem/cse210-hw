namespace foundation1;
public class Video(){
    public int getVideo1(){
        System.Console.WriteLine("For the first video: ");
        System.Console.WriteLine("What is the title?");
        string title1 = Console.ReadLine();
        System.Console.WriteLine("Who is the author?");
        string author1 = Console.ReadLine();
        System.Console.WriteLine("How many comments does the video have?");
        string cA1 = Console.ReadLine();
        int commentAmount1= int.Parse(cA1);
        return commentAmount1;
    }

    public int getVideo2(){
        System.Console.WriteLine("For the second video: ");
        System.Console.WriteLine("What is the title?");
        string title2 = Console.ReadLine();
        System.Console.WriteLine("Who is the author?");
        string author2 = Console.ReadLine();
        System.Console.WriteLine("How many comments does the video have?");
        string cA2 = Console.ReadLine();
        int commentAmount2= int.Parse(cA2);
        return commentAmount2;
    }
    public int getVideo3(){
        System.Console.WriteLine("For the third video: ");
        System.Console.WriteLine("What is the title?");
        string title3 = Console.ReadLine();
        System.Console.WriteLine("Who is the author?");
        string author3 = Console.ReadLine();
        System.Console.WriteLine("How many comments does the video have?");
        string cA3 = Console.ReadLine();
        int commentAmount3= int.Parse(cA3);
        return commentAmount3;
    }
    Comment commentAction = new Comment();
    commentAction.getV1Comments();
}
