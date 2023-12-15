

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2; //otsime jääki kui jagame number kahega

if (result != 0) // != ei võrdu
{
    Console.WriteLine("User number is odd.");
} else
{
    Console.WriteLine("User number is even.");
}