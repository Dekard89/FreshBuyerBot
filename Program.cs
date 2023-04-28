using Telegram.Bot;
using Telegram.Bot.Types;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegrambot
{
    internal class Program
    {
        static void Main()
        {
            var botClient = new TelegramBotClient("6048952678:AAHcbgbMFMU0WS3Umma37SoM3TAu--Wt-K8");
            botClient.StartReceiving(Update, Error);
            
            Console.ReadLine();
            

            string path = @"File.doc";



        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        async private static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var massege = update.Message;

            if (massege != null)
            {

                if (massege.Text.ToLower().Contains("здарова"))
                    await botClient.SendTextMessageAsync(massege.Chat.Id, "ну здорова, введи команду");
                if (massege.Text.ToLower().Contains("привет"))
                    await botClient.SendTextMessageAsync(massege.Chat.Id, "ну привет,введи команду");
                if (massege.Text.ToLower().Contains("поиск"))
                    await botClient.SendTextMessageAsync(massege.Chat.Id, "что ищем");
                var command = massege.Text.ToLower();
                string path = @"File.doc";
                using (var streamRider = new StreamReader(path))
                   while





            }


        }

       
    }
}

