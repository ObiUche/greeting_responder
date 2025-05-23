/*
- Greetings Responder
- Take the users name 
- Then respond with a greeting 

*/

string user_name = "";


Console.WriteLine("Hello! What is your name?");

user_name = Console.ReadLine() ?? "";

if (string.IsNullOrEmpty(user_name))
{
    Console.WriteLine("Please enter your name:");
}
else
{
    Console.WriteLine($"Hello {user_name}! Welcome to greetings responder!");
}



