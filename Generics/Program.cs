
class Program
{
    internal interface ITask<TResult>
    {
        TResult Perform();
    }

    internal class EmailTask : ITask<string>
    {
        
        public string Message { get; set; }
        
        public string Recipient { get; set; }
        
        public string Perform()
        {
            return $"Email sent to {Recipient}, content is:\n{Message}";
        }
    }

    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }

        public string Perform()
        {
            return $"Report {ReportName} generated successfully.";
        }
    }

    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
            private TTask task;

            public TaskProcessor(TTask task)
            {
                this.task = task;
            }

            public TResult Execute()
            {
                return task.Perform();
            }
    }
    
    static void Main(string[] args)
    {
        EmailTask emailTask = new EmailTask() { Message = "Helo blah", Recipient = "example@example.com" };
        ReportTask reportTask = new ReportTask() {ReportName = "Code Report 1"};

        var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
        var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

        Console.WriteLine(emailProcessor.Execute());
        Console.WriteLine(reportProcessor.Execute());

        Console.ReadKey();
    }
}
