using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork5
{
    public static class Starter
    {
        public static void Run()
        {
            Random random = new Random();

            for (int i = 0; i < 101; i++)
            {
                int methodNumber = random.Next(1, 4);

                switch (methodNumber)
                {
                    case 1:
                        var result = Actions.First();
                        HandleResult(result);
                        break;
                    case 2:
                        var result2 = Actions.Second();
                        HandleResult(result2);
                        break;
                    case 3:
                        var result3 = Actions.Third();
                        HandleResult(result3);
                        break;
                }
            }

            Logger log = Logger.Instance;
            File.WriteAllText("log.txt", log.GetLogs());
        }

        public static void HandleResult(Result result)
        {
            if (!result.Status)
            {
                Logger log = Logger.Instance;
                log.Log(result.ErrorMessage, Logger.LogLevel.Error);
            }
        }
    }
}
