using System;
using System.Runtime.CompilerServices;
using System.Transactions;
namespace foundation1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        System.Console.WriteLine("Foundation 1 Videos");

        var videos = new List<Video>();
        var comments = new List<Comment>();

        var video1 = new Video("The Sahara", "Brek Eisner", 3); 
            var comment1 = new Comment("ChrisinDesMoines", "I've come to the conclusion that this is one of those movies that you either love or hate, and I'm one of the 'love it' guys.");
            var comment2 = new Comment("SmithWhite", "The dialog is amusing, the plot easy to follow despite its complexities and the action virtually nonstop.");
            var comment3 = new Comment("aylwardpaul", "I don't understand why this wasn't a bigger hit with the public. If you're looking for a fun adventure film with good production values, here it is.");
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
        videos.Add(video1);
        var video2 = new Video("Beauty and the Beast", "Bill Condon", 3);
        videos.Add(video2);
        var video3 = new Video("Leap Year", "Anand Tucker", 3);
        videos.Add(video3);

        foreach(var v in videos) {
            System.Console.WriteLine($"{v}");
        }

            var comment4 = new Comment("vithawin", "If you are a thoughtful person, artistic, deep, you will be seeing the details like masterful editing skills. the flow and the transition is absolutely magical between scenes.");
            var comment5 = new Comment("luzm88", "The plot was almost completely the same as that of the cartoon version, with a few additions. I very much loved these new additions as they added depth to the story.");
            var comment6 = new Comment("AlsExGal", "As much as it pains me to see movies being remade, I find that I am able to give Disney a pass for this. I thoroughly enjoyed Beauty and the Beast.");
            comments.Add(comment4);
            comments.Add(comment5);
            comments.Add(comment6);

            var comment7 = new Comment("ilostthenestegg", "The movie is extremely charming due to the terrific chemistry... The characters seem simple at first, but we see the depth beyond them as the move goes on.");
            var comment8 = new Comment("hall895", "It is not at all a terrible movie. Yes, it is very predictable and formulaic. But sometimes you have to remember in life there are established formulas because those formulas work.");
            var comment9 = new Comment("chexsmate", "I've seen this movie multiple times over the years and just watched it again. I have to admit watching her doing that much walking on Ireland's country roads made my feet hurt!");
            comments.Add(comment7);
            comments.Add(comment8);
            comments.Add(comment9);

            foreach(var c in comments){
                System.Console.WriteLine($"{c}");
            }
    }
        // Video videoAction = new Video();
        // videoAction.getVideo1();
        // videoAction.getVideo2();
        // videoAction.getVideo3();
}