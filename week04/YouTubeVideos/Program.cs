using System;

class Program
{
    static void Main(string[] args)
    {   
        // Comment Instance 
        Comment com1v1 = new Comment("Aldair Rutte", "What a great video!");
        Comment com2v1 = new Comment("Pixart-97", "Hahaha, that was funny.");
        Comment com3v1 = new Comment("Juan Carlo Magno", "This is my favorite song");

        Comment com1v2 = new Comment("Enrique Filipo", "I remember this music from when I was little");
        Comment com2v2 = new Comment("Oscarx-120", "Will they release an even better one?");
        Comment com3v2 = new Comment("FiedoÑol145", "the best radio of all");
        Comment com4v2 = new Comment("MagicMan", "I was really looking forward to this song, bro.");

        Comment com1v3 = new Comment("DedSec47", "This cartoon is very good.");
        Comment com2v3 = new Comment("Manolo-Rojas", "A cameo can be seen at 1:46");
        Comment com3v3 = new Comment("Marita Sanchez13", "Where can I watch the complete series?");
        Comment com4v3 = new Comment("Hualdo-Muñoz66", "He runs to watch this cartoon");
        Comment com5v3 = new Comment("Mirta Mirta de Jesus", "first comment yippee!!");
        
        // Video Instance
        Video v1 = new Video("BVB - Fallen Angels", "Black Veil Brides", 180);
        Video v2 = new Video("Maluma - Brown Eyes", "Universal Radio", 500);
        Video v3 = new Video("Kid vs Kat", "Jetix", 1000);

        // Adding comments
        v1.AddComment(com1v1);
        v1.AddComment(com2v1);
        v1.AddComment(com3v1);

        v2.AddComment(com1v2);
        v2.AddComment(com2v2);
        v2.AddComment(com3v2);
        v2.AddComment(com4v2);

        v3.AddComment(com1v3);
        v3.AddComment(com2v3);
        v3.AddComment(com3v3);
        v3.AddComment(com4v3);
        v3.AddComment(com5v3);
        
        // Show for Console
        v1.DisplayInfoVideo();
        v2.DisplayInfoVideo();
        v3.DisplayInfoVideo();
    }
}