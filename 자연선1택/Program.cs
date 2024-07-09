using System;
using System.Windows.Forms;
using Hangfire;
using Hangfire.MemoryStorage;

namespace 자연선1택
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Hangfire 초기화
            GlobalConfiguration.Configuration
                .UseMemoryStorage(); // 메모리 저장소 사용

            // Hangfire 서버 시작
            using (var server = new BackgroundJobServer(new BackgroundJobServerOptions
            {
                WorkerCount = 50 // 동시 실행할 작업 수를 50으로 설정
            }))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
