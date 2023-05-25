using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork5
{
    public class Actions
    {
        public static Result First()
        {
            Logger log = Logger.Instance;
            log.Log("Start method:First", Logger.LogLevel.Info);
            return new Result(true, "Action failed by а reason:Result");
        }

        public static Result Second()
        {
            Logger log = Logger.Instance;
            log.Log("Skipped logic in method:Second", Logger.LogLevel.Warning);
            return new Result(true, "Action failed by а reason:Result");
        }

        public static Result Third()
        {
            Logger log = Logger.Instance;
            log.Log("I broke a logic", Logger.LogLevel.Error);
            return new Result(false, "Action failed by а reason:Result");
        }
    }
}
