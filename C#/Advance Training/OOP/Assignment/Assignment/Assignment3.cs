using System;

public class Mail
{
    public string Sender { get; set; }

    public string Recipients { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public Mail(string sender)
    {
        Sender = sender;
    }

    public virtual void SendEmail()
    {
      
    }
}

public class SendGrid : Mail
{
    public SendGrid(string sender) : base(sender) { }

    public override void SendEmail()
    {
        Console.WriteLine("SendGrid successfully sent to {0}\nSender: {1}\nSubject: {2}\nContent: {3}",
                          Recipients, Sender, Subject, Body);
    }
}

public class MailChimp : Mail
{
    public MailChimp(string sender) : base(sender) { }

    public override void SendEmail()
    {
        Console.WriteLine("MailChimp successfully sent to {0}\nSender: {1}\nSubject: {2}\nContent: {3}",
                          Recipients, Sender, Subject, Body);
    }
}

class Assignment3
{
    //static void Main(string[] args)
    //{
    //    SendGrid sendGridEmail = new SendGrid("youremail@yourdomain.com");
    //    sendGridEmail.Recipients = "emailID@domain.com";
    //    sendGridEmail.Subject = "Just a Test";
    //    sendGridEmail.Body = "Hi Name, How are you?";
    //    sendGridEmail.SendEmail();

    //    MailChimp mailChimpEmail = new MailChimp("youremail@yourdomain.com");
    //    mailChimpEmail.Recipients = "emailID@domain.com";
    //    mailChimpEmail.Subject = "Just a Test";
    //    mailChimpEmail.Body = "Hi Name, How are you?";
    //    mailChimpEmail.SendEmail();

    //    Console.ReadLine();
    //}
}
