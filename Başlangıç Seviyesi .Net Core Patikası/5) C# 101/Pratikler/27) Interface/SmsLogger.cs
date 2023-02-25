namespace _27__Interface;
public class SmsLogger : ILogger
{
    public void WriteLog()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Sms olarak yazar.");
    }

}