using Telegram.Bot;
using Telegram.Bot.Types;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using Telegram.Bot.Exceptions;

class Program
{
    private static TelegramBotClient botClient;
    private static string Token = "6048952678:AAHcbgbMFMU0WS3Umma37SoM3TAu--Wt-K8";

    private static  ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
  {
    new KeyboardButton[] { "поиск", "Калькулятор" },
})
    {
        ResizeKeyboard = true
    };

    static void Main(string[] args)
    {
        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        botClient = new TelegramBotClient(Token);
       
        var me =  botClient.GetMeAsync();

        
 
        botClient.StartReceiving(Updater, Erorr);
        Console.ReadLine(); 
    }

    private  static Task Erorr(ITelegramBotClient arg1, Exception exception, CancellationToken cancellationToken)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(ErrorMessage);
        return Task.CompletedTask;

    }

    private async static Task Updater(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        var msg = update.Message;

        if (msg != null)
        {
            if (msg.Text.ToLower().Contains("привет") || msg.Text.ToLower().Contains("здорова"))
            {
                await botClient.SendTextMessageAsync(msg.Chat.Id, $"ну, {msg.Text},начнём?", replyMarkup:replyKeyboardMarkup);
                

            }

            return;

        }


    }

}

