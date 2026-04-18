namespace examin2.Domain.Models;

//7
public class Maths
{
    public double Abs(double value)
    {
        if (value < 0)
        {
            return -value;
        }
        return value;
    }
    public float Abs(float value)
    {
        if (value < 0)
        {
            return - value;
        }
        return value;
    }
    public int Abs(int value)    
    {
        if (value < 0)
        {
            return - value;
        }
        return value;
    }
    public double Pow(double x, double y)
    {
        if (y == 0)
        {
            return 1;
        }
        double result = 1;
        for (int i = 0; i < y; i++)       
        {
            result *= x;
        }
        return result;
    }
    double Sqrt(double value)
    {
    for (int i=0;i<value;i++)
    {
        if (i * i == value)
        {
            return i;
        }
    }
    return -1;
    }
    
    public int Max(int val1, int val2)
    {
        if (val1 > val2)
        {
            return val1;
        }
        return val2;
    }
    public double Min(int val1, int val2)
    {
        if (val1 < val2)
        {
            return val1;
        }
        return val2;
    }
    const double PI = 3.14;
    const double E = 2.71;
}

//8
// class Post
// {
//     public string? Title {get;set;}
//     public string? Description {get;set;}
//     public int Likes{get;set;}
//     public List<string> Comments = new List<string>();
//     public bool IsPublished{get;set;}
//     public Post(string title, string description)
//     {
//         Title = title;
//         Description = description;
//         Likes = 0;
//         IsPublished = false;
//     }
//     public void Publish()
//     {
//         IsPublished = true;
//     }
//     public void Like()
//     {
//         Likes++;
//     }
//     public void AddComment(string comment)
//     {
//         Comments.Add(comment);
//     }

// }