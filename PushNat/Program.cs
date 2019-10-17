using System;

namespace PushNotification
{
    // Nuget имя пакета firebaseAdmin
    class Program
    {
        static void Main(string[] args)
        {

            MobileMessagingClient client = new MobileMessagingClient();
            Console.WriteLine("Topic: ");
            var tokenId = "cxSJw4R5jjs:APA91bGh6l9ahNi2MTGraxyNntWCIn7nHvpVtZRG9p9UTp8Aq2OhZg38WQ3FZWGrlkeoPV9u3xj7wQMOCOvwSmsDaDp0D4sbHcAOxYMlINtKkGyJbBQC0tHmNxzZf_S1wocI9ENmEGBA";
            var topic = Console.ReadLine();
            Console.WriteLine("Notification message: ");
            var notification = Console.ReadLine();
            client.SendNotification(tokenId, topic, notification).Wait();



        }
    }
}
