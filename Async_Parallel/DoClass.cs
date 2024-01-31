using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Parallel
{
    class DoClass
    {
        public string DoSomething()
        {
            Thread.Sleep(5000);
            return "Hello synchrone";
        }

        public string DoSomethingTask()
        {
            var tsk = new Task<string>(
                () =>
                {
                    Thread.Sleep(3000);
                    return "Hello Taskchrone";
                }
                );
            tsk.Start();
            //tsk.Wait();
            //Task.WaitAll()
            return tsk.Result;
        }

        public async Task<string> DoSomethingAsync()
        {
            return await Task.Run(
                () =>
                {
                    Thread.Sleep(2000);
                    return "Hello Asynchrone";
                }
                );
        }
    }
}
