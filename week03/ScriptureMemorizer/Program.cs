using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        const int HIDE = 3;

        // create list of scriptures
        List<Scripture> scriptures = new List<Scripture>();

        Reference reference1 = new Reference("2 Nephi", 2, 25);
        string text1 = "Adam fell that men might be; and men are, that they might have joy.";
        Scripture scripture1 = new Scripture(reference1, text1);
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("Mosiah", 2, 17);
        string text2 = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Scripture scripture2 = new Scripture(reference2, text2);
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("Moses", 1, 39);
        string text3 = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
        Scripture scripture3 = new Scripture(reference3, text3);
        scriptures.Add(scripture3);

        Reference reference4 = new Reference("Daniel", 2, 44, 45);
        string text4 = "And in the days of these kings shall the God of heaven set up a kingdom, which shall never be destroyed: and the kingdom shall not be left to other people, but it shall break in pieces and consume all these kingdoms, and it shall stand for ever. Forasmuch as thou sawest that the stone was cut out of the mountain without hands, and that it brake in pieces the iron, the brass, the clay, the silver, and the gold; the great God hath made known to the king what shall come to pass hereafter: and the dream is certain, and the interpretation thereof sure.";
        Scripture scripture4 = new Scripture(reference4, text4);
        scriptures.Add(scripture4);

        Reference reference5 = new Reference("John", 3, 5);
        string text5 = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
        Scripture scripture5 = new Scripture(reference5, text5);
        scriptures.Add(scripture5);

        Reference reference6 = new Reference("Moroni", 7, 16, 17);
        string text6 = "For behold, the Spirit of Christ is given to every man, that he may know good from evil; wherefore, I show unto you the way to judge; for every thing which inviteth to do good, and to persuade to believe in Christ, is sent forth by the power and gift of Christ; wherefore ye may know with a perfect knowledge it is of God. But whatsoever thing persuadeth men to do evil, and believe not in Christ, and deny him, and serve not God, then ye may know with a perfect knowledge it is of the devil; for after this manner doth the devil work, for he persuadeth no man to do good, no, not one; neither do his angels; neither do they who subject themselves unto him.";
        Scripture scripture6 = new Scripture(reference6, text6);
        scriptures.Add(scripture6);

        Reference reference7 = new Reference("D&C", 64, 9, 11);
        string text7 = "Wherefore, I say unto you, that ye ought to forgive one another; for he that forgiveth not his brother his trespasses standeth condemned before the Lord; for there remaineth in him the greater sin. I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men. And ye ought to say in your hearts—let God judge between me and thee, and reward thee according to thy deeds.";
        Scripture scripture7 = new Scripture(reference7, text7);
        scriptures.Add(scripture7);

        // get random scripture to display
        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);

        do
        {
            Console.Clear();

            Console.WriteLine(scriptures[randomIndex].GetDisplayText());
            Console.Write("> ");

            scriptures[randomIndex].HideRandomWords(HIDE);

            if (scriptures[randomIndex].AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scriptures[randomIndex].GetDisplayText());
                Console.Write("> ");
            }
        } while (Console.ReadLine() != "quit" && !scriptures[randomIndex].AllWordsHidden());
    }
}