using examin2.Domain.Models;

//7
// Maths math = new Maths();
// Console.WriteLine(math.Abs(-5));
// Console.WriteLine(math.Abs(-5.5));
// Console.WriteLine(math.Abs(-5.5));
// Console.WriteLine(math.Pow(2, 3));
// Console.WriteLine(math.Max(5, 10));
// Console.WriteLine(math.Min(5, 10));


//8
var post = new Post("Hello World", "This is my first post!");
List<Post> posts = new List<Post>();
var post1 = new Post("Hello World", "This is my first post!");
post1.Likes = 10;
post1.Comments.Add("Great post!");
post1.Comments.Add("Thanks for sharing!");
posts.Add(post1);
var post2 = new Post("Yo bro", "This is my second post!");
post2.Likes = 5;
post2.Comments.Add("Nice post!");
posts.Add(post2);  
var post3 = new Post("Hello again", "This is my third post!");
post3.Likes = 15;
post3.Comments.Add("Awesome post!");
post3.Comments.Add("Keep it up!");
post3.Comments.Add("Looking forward to more posts!");
posts.Add(post3);
var post4 = new Post("Hi there", "This is my fourth post!");
post4.Likes = 2;
post4.Comments.Add("Good post!");   
var post5 = new Post("Amazing!", "This is my fifth post!");
post5.Likes = 20;
post5.Comments.Add("Excellent post!");
post5.Comments.Add("Very informative!");
post5.Comments.Add("Thanks for sharing!");
post5.Comments.Add("Great job!");
posts.Add(post5);
foreach (var p in posts)
{    
    Console.WriteLine($"{p.Title} - {p.Description} - number of Likes: {p.Likes}");       
}
