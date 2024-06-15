using Microsoft.EntityFrameworkCore;

namespace MoviesFinal1406.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            SeedData();
        }

        private void SeedData()
        {
            if (!Movies.Any())
            {
                Movies.AddRange(
                    new Movie
                    {
                        Title = "The Green Mile",
                        Director = "Frank Darabont",
                        Genre = "Crime, Drama, Fantasy",
                        Year = 1999,
                        PosterPath = "/images/1.jpg",
                        Description = "The plot of the film \"The Green Mile\": in 1935, an African-American man of incredible size named John was admitted to the Cold Mountain Federal Penitentiary. He was sentenced posthumously for the rape and murder of two girls. John was very calm and knowing that he did not commit this crime was ready to walk the green mile. This was the name of the green corridor along which the convicts made their final journey to execution in the electric chair...",

                    },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Genre = "Crime, Drama",
                    Year = 1994,
                    PosterPath = "/images/2.jpg",
                    Description = "The Shawshank Redemption Plot: Bank Vice President Andy Dufresne was sentenced to two life sentences for murders he did not commit.For the death of his wife and her lover, a thirty - year - old guy received a life sentence.Unable to accept his fate, Andy has been preparing an escape plan for many years. During the time that the main character arrived in prison, he managed to earn authority, respect and trust from both the prisoners and the prison authorities.At the same time, Andy helped his bosses earn large sums of money.The main character could not think that one day the actress, who he madly likes and has no idea about his existence, would save his life.",

                },
                new Movie
                {
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Genre = "Crime, Drama",
                    Year = 1972,
                    PosterPath = "/images/3.jpg",
                    Description = "The plot of the film \"The Godfather\": the film begins in the summer of 1945 and has a duration of ten years. The Italian-American family of mafioso Don Vino Corleone, which has its own laws and traditions, rules in the big city of New York. Don Vito Corleone himself is the head of the clan and conducts his affairs according to old and cruel mafia concepts. He gives his daughter away in marriage, and his beloved son Michael returns from the war. Michael does not share the concept of family at all and does not want to join the family business. Not everyone was happy with the ways of the great Corleone, and an attempt was made on his life....",

                },
                new Movie
                {
                    Title = "Fight Club",
                    Director = "David Fincher",
                    Genre = "Drama",
                    Year = 1999,
                    PosterPath = "/images/4.jpg",
                    Description = "The plot of the movie \"Fight Club\": the narrator of the story is a typical yuppie. He is thirty and a hired worker. He also suffers from insomnia, and cannot determine where is a dream and where is reality. Instead of taking medications, the doctor suggests that he play sports and periodically visit a group of testicular cancer patients. A visit to this group should prove to the narrator what real torment is, and so that he understands that his insomnia is mere trifle compared to cancer. Our narrator also dreams of a turning point that will turn his whole life around. One day at a bar he meets Tyler Duren, a soap salesman who has an impressive gift...",

                },
                new Movie
                {
                    Title = "Forrest Gump",
                    Director = "Robert Zemeckis",
                    Genre = "Drama, Romance",
                    Year = 1994,
                    PosterPath = "/images/5.jpg",
                    Description = "The plot of the film \"Forrest Gump\" tells us the story of the main character named Forrest Gump. Forrest grew up in Alabama. He was raised by a single mother. The little boy has problems with his spine and wears braces. Also, his IQ level is only 75 points, and this is not enough to enter school. Many years later, Forrest becomes a millionaire. Despite his great fortune and celebrity, the main character remains the same kind and sympathetic person.",

                },
                new Movie
                {
                    Title = "Titanic",
                    Director = "James Cameron",
                    Genre = "Drama, Romance",
                    Year = 1997,
                    PosterPath = "/images/6.jpg",
                    Description = "One of the most notorious disasters of the 20th century was the death of the “unsinkable” liner Titanic. The plot of the film tightly interweaves the fate of the steel giant and many people in one way or another connected with it. And the main characters become a young couple. Two lovers from different walks of life.....",

                },
                new Movie
                {
                    Title = "The Wolf of Wall Street",
                    Director = "Martin Scorsese",
                    Genre = "Biography, Comedy, Crime",
                    Year = 2013,
                    PosterPath = "/images/7.jpg",
                    Description = "Jordan Belfort is an up-and-coming broker leading a dissolute lifestyle. Thanks to his intelligence and enormous ambitions, he ends up on Wall Street, where he achieves great success. Huge money and the bad influence of his boss lead to Jordan beginning to lead a riotous lifestyle. However, all this does not stop the guy from increasing his fortune, which grows to very large proportions. For his iron grip and ability to conduct business, the young man receives the nickname “The Wolf of Wall Street.” However, the FBI begins to take an interest in his large earnings, as a result of which he is put under surveillance......",

                },
                new Movie
                {
                    Title = "Rocky IV ",
                    Director = "Sylvester Stallone",
                    Genre = "Drama, Sport",
                    Year = 1985,
                    PosterPath = "/images/8.jpg",
                    Description = "Rocky Balboa deservedly enjoys a quiet family life. His life is settled, his family is nearby, and even his wife’s always muttering brother does not bother him much. But life does not allow the boxing veteran to wait until old age in peace. Bosom friend Apollo Creed accepts an invitation to an exhibition fight with the World Amateur Champion from the Soviet Union, Ivan Drago. But the captain of the Soviet army has different views on this battle. He gives it his all. His crushing blows send Creed to the floor of the ring, now forever. Rocky Balboa is eager to avenge his friend. But the battle can only take place in Russia, on enemy territory. And Rocky accepts another challenge from fate.....",

                },
                new Movie
                {
                    Title = "House of Gucci",
                    Director = "Ridley Scott",
                    Genre = "Biography, Crime, Drama",
                    Year = 2021,
                    PosterPath = "/images/9.jpg",
                    Description = "The film is based on real events that happened to the famous Gucci family. Maurizio is the grandson of the brand's founder, who was married to Patrizia Reggiani for more than ten years. They raised two children together, but at one point the man announced that he was leaving for his young mistress Paola Francini. The wife cannot forgive the betrayal and decides to resort to radical measures. Patricia hires a hitman to get rid of her unfaithful husband. The struggle for happiness, money and power is gradually gaining unprecedented momentum......",

                },
                new Movie
                {
                    Title = "Bohemian Rhapsody",
                    Director = "Bryan Singer",
                    Genre = "Biography, Drama",
                    Year = 2018,
                    PosterPath = "/images/10.jpg",
                    Description = "The plot of the film tells about the famous mega-popular rock band Queen and its outstanding vocalist Freddie Mercury. This man defied all stereotypes and became one of the most popular artists in the world. Millions of fans around the planet enjoyed his work. But the film will tell not only about the dizzying path to the success of this team, but also about its almost collapse, since Freddie’s lifestyle at a certain point simply got out of control. The viewer will also be shown the story of the triumphant reunion of the musicians on the eve of the Live Aid concert, which ultimately became one of the greatest performances in the history of rock music.....",

                },
                new Movie
                {
                    Title = "Why him?",
                    Director = "John Hamburg",
                    Genre = "Comedy",
                    Year = 2017,
                    PosterPath = "/images/11.jpg",
                    Description = "This romantic funny comedy follows a feud between Silicon Valley billionaire and his girlfriend’s father starring James Franco and Bryan Cranston! Attentive and careful father Ned Fleming comes to visit his daughter Stephanie and gets totally shocked by her boyfriend – clumsy and sometimes insolent Laird. Ned’s resentment sharply increases as Laird is going to marry Stephanie. His daughter could have chosen any of all the guys, but why him?"
                },
                new Movie
                {
                    Title = "The Intouchables",
                    Director = "Olivier Nakache, Éric Toledano",
                    Genre = "Comedy, Drama",
                    Year = 2011,
                    PosterPath = "/images/12.jpg",
                    Description = "After suffering in an accident, the wealthy aristocrat Philippe hires as his assistant the man least suited for the job - a young resident of the suburb of Drissa, who has just been released from prison. Despite the fact that Philippe is confined to a wheelchair, Driss manages to bring a spirit of adventure into the measured life of the aristocrat."
                }
            );
                SaveChanges();
            }
        }
    }
}