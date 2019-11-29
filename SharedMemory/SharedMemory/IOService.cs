using System.IO;
using System.Threading;

namespace SharedMemory
{
    public class IOService
    {
        private static IOService instance = null;
        private static readonly Mutex mutex = new Mutex();

        IOService()
        {
        }

        public static IOService Instance
        {
            get
            {
                mutex.WaitOne();

                if (instance == null)
                {
                    instance = new IOService();
                }

                mutex.ReleaseMutex();

                return instance;
            }
        }

        public string ReadChatFile()
        {
            mutex.WaitOne();

            string chatContents = System.IO.File.ReadAllText("../../chat-history.txt");

            mutex.ReleaseMutex();

            return chatContents;
        }

        public void AppendMessageToChat(string message)
        {
            mutex.WaitOne();

            using (StreamWriter outputFile = new StreamWriter("../../chat-history.txt", true))
            {
                outputFile.WriteLine(message);
            }

            mutex.ReleaseMutex();
        }
    }
}
