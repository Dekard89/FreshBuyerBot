using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBuyerBot
{
    internal static class Sourse
    {
        private static Dictionary<string, string> DataBase = new Dictionary<string, string>() {
          { "абрикос", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%B1%D1%80%D0%B8%D0%BA%D0%BE%D1%81.png" }, { "авокадо", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%B2%D0%BE%D0%BA%D0%B0%D0%B4%D0%BE.png" },
            { "айсберг", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%B9%D1%81%D0%B1%D0%B5%D1%80%D0%B3.png" }, { "ананас", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BD%D0%B0%D0%BD%D0%B0%D1%81.png" }, { "ананас2", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BD%D0%B0%D0%BD%D0%B0%D1%812.png" },
            { "апельсин", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BF%D0%B5%D0%BB%D1%8C%D1%81%D0%B8%D0%BD.png" }, { "апельсин1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BF%D0%B5%D0%BB%D1%8C%D1%81%D0%B8%D0%BD1.png" }, { "апельсин2.", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BF%D0%B5%D0%BB%D1%8C%D1%81%D0%B8%D0%BD2.png" },
            { "апельсин3", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D0%BF%D0%B5%D0%BB%D1%8C%D1%81%D0%B8%D0%BD3.png" }, { "арбуз", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B0%D1%80%D0%B1%D1%83%D0%B7.png" }, { "баклажан", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B1%D0%B0%D0%BA%D0%BB%D0%B0%D0%B6%D0%B0%D0%BD.png" },
            { "банан", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B1%D0%B0%D0%BD%D0%B0%D0%BD.png" }, { "бананы.", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B1%D0%B0%D0%BD%D0%B0%D0%BD%D1%8B.png" }, { "бананы1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B1%D0%B0%D0%BD%D0%B0%D0%BD%D1%8B1.png" },
            { "брокколи", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B1%D1%80%D0%BE%D0%BA%D0%BA%D0%BE%D0%BB%D0%B8.png" }, { "виноград", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B2%D0%B8%D0%BD%D0%BE%D0%B3%D1%80%D0%B0%D0%B4.png" }, { "гранат", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B0%D0%BD%D0%B0%D1%82.png" },
            { "грейпфрут", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B5%D0%B9%D0%BF%D1%84%D1%80%D1%83%D1%82.png" }, { "грейпфрут1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B5%D0%B9%D0%BF%D1%84%D1%80%D1%83%D1%821.png" }, { "грейпфрут2", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B5%D0%B9%D0%BF%D1%84%D1%80%D1%83%D1%822.png" },
            { "грибы", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B8%D0%B1%D1%8B.png" }, { "грибы1.", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D0%B8%D0%B1%D1%8B1.png" }, { "груша", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D1%83%D1%88%D0%B0.png" }, { "груша1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D1%83%D1%88%D0%B01.png" },
            { "груша2", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D1%83%D1%88%D0%B02.png" }, { "груша3", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B3%D1%80%D1%83%D1%88%D0%B03.png" }, { "дыня", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B4%D1%8B%D0%BD%D1%8F.png" }, { "дыня1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B4%D1%8B%D0%BD%D1%8F1.png" },
            { "дыня2", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B4%D1%8B%D0%BD%D1%8F2.png" }, { "зелень", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B7%D0%B5%D0%BB%D0%B5%D0%BD%D1%8C.png" }, { "инжир", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%B8%D0%BD%D0%B6%D0%B8%D1%80.png" }, { "кабачок", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B0%D0%B1%D0%B0%D1%87%D0%BE%D0%BA.png" },
            { "капуста пекинка", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B0%D0%BF%D1%83%D1%81%D1%82%D0%B0%20%D0%BF%D0%B5%D0%BA%D0%B8%D0%BD%D0%BA%D0%B0.png" }, { "капуста цветная", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B0%D0%BF%D1%83%D1%81%D1%82%D0%B0%20%D1%86.png" }, { "капуста", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B0%D0%BF%D1%83%D1%81%D1%82%D0%B0.png" },
            { "картофель", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B0%D1%80%D1%82%D0%BE%D1%84%D0%B5%D0%BB%D1%8C.png" }, { "киви", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B8%D0%B2%D0%B8.png" }, { "киви1", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B8%D0%B2%D0%B81.png" }, { "киви2", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%B8%D0%B2%D0%B82.png" },
            { "клубника", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D0%BB%D1%83%D0%B1%D0%BD%D0%B8%D0%BA%D0%B0.png" }, {"крыжовник", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BA%D1%80%D1%8B%D0%B6%D0%BE%D0%B2%D0%BD%D0%B8%D0%BA.png" }, { "лайм", "https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D0%B0%D0%B9%D0%BC.png"},{"лимон","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D0%B8%D0%BC%D0%BE%D0%BD.png"},
            {"лимон1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D0%B8%D0%BC%D0%BE%D0%BD1.png"},{"лимон2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D0%B8%D0%BC%D0%BE%D0%BD2.png"},{"лук порей","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D1%83%D0%BA%20%D0%BF%D0%BE%D1%80%D0%B5%D0%B9.png"},{"лук","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BB%D1%83%D0%BA.png"},
            {"малина ежевика","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%B0%D0%BB%D0%B8%D0%BD%D0%B0.png"},{"манго","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%B0%D0%BD%D0%B3%D0%BE.png"},{"мандарин","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%B0%D0%BD%D0%B4%D0%B0%D1%80%D0%B8%D0%BD.png"},{"мандарин1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%B0%D0%BD%D0%B4%D0%B0%D1%80%D0%B8%D0%BD1.png"},
            {"мандарин2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%B0%D0%BD%D0%B4%D0%B0%D1%80%D0%B8%D0%BD2.png"},{"морковь","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%BE%D1%80%D0%BA%D0%BE%D0%B2%D1%8C.png"},{"морковь1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BC%D0%BE%D1%80%D0%BA%D0%BE%D0%B2%D1%8C1.png"},{"нектарин","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BD%D0%B5%D0%BA%D1%82%D0%B0%D1%80%D0%B8%D0%BD.png"},
            {"нектарин1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BD%D0%B5%D0%BA%D1%82%D0%B0%D1%80%D0%B8%D0%BD1.png"},{"нектарин2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BD%D0%B5%D0%BA%D1%82%D0%B0%D1%80%D0%B8%D0%BD2.png"},{"огурцы","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BE%D0%B3%D1%83%D1%80%D1%86%D1%8B.png"},{"перец","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D0%B5%D1%86.png"},
            {"перец1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D0%B5%D1%861.png"},{"перец2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D0%B5%D1%862.png"},{"персик","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D1%81%D0%B8%D0%BA.png"},{"персик1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D1%81%D0%B8%D0%BA1.png"},
            {"персик2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D0%BF%D0%B5%D1%80%D1%81%D0%B8%D0%BA2.png"},{"редис","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%80%D0%B5%D0%B4%D0%B8%D1%81.png"},{"редька репа","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%80%D0%B5%D0%B4%D1%8C%D0%BA%D0%B0.png"},{"салат","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%81%D0%B0%D0%BB%D0%B0%D1%82.png"},
            {"свекла","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%81%D0%B2%D0%B5%D0%BA%D0%BB%D0%B0.png"},{"сельдерей","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%81%D0%B5%D0%BB%D1%8C%D0%B4%D0%B5%D1%80%D0%B5%D0%B9.png"},{"сельдерей1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%81%D0%B5%D0%BB%D1%8C%D0%B4%D0%B5%D1%80%D0%B5%D0%B91.png"},
            {"слива","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%81%D0%BB%D0%B8%D0%B2%D0%B0.png"},{"томат","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%82%D0%BE%D0%BC%D0%B0%D1%82.png"},{"тыква","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%82%D1%8B%D0%BA%D0%B2%D0%B0.png"},{"хурма","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%85%D1%83%D1%80%D0%BC%D0%B0.png"},
            {"черешня вишня","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%87%D0%B5%D1%80%D0%B5%D1%88%D0%BD%D1%8F.png"},{"чеснок","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%87%D0%B5%D1%81%D0%BD%D0%BE%D0%BA.png"},{"яблоко","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE.png"},{"яблоко1","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE1.png"},
            {"яблоко2","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE2.png"},{"яблоко3","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE3.png"},{"яблоко4","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE4.png"},
            {"яблоко5","https://github.com/Dekard89/TelegramBotFreshBuyer/blob/main/%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE5.png" }};

        async static public void SearchResult(Message message, ITelegramBotClient botClient)
        {
           

            var answer = DataBase.Where(x => x.Key.ToLower().Contains(message.Text));

            foreach (var item in answer)
            {
                await botClient.SendPhotoAsync(message.Chat.Id, item.Value + "?raw=true");
            }



        }
       
    }
}
