namespace TaskDialogSample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ThreadException += Application_ThreadException;
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var submitError = new TaskDialogButton("Submit Error");
            submitError.Click += (s, e) => MessageBox.Show(
                "Thank you for notifying us. We're on it. Seriously.", "Submit Error");

            TaskDialog.ShowDialog(new TaskDialogPage
            {
                Caption = "Application Exception",
                Heading = "An exception has occurred!",
                Text = e.Exception.Message,
                Icon = TaskDialogIcon.Error,
                AllowCancel = true,
                Expander = new TaskDialogExpander
                {
                    Text = e.Exception.StackTrace,
                    CollapsedButtonText = "Stack Trace",
                },
                Buttons = { TaskDialogButton.OK, submitError },
                DefaultButton = TaskDialogButton.OK,
                SizeToContent = true,
            });

            //MessageBox.Show(e.Exception.ToString(), "Application Exception");
        }
    }
}