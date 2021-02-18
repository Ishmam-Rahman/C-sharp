using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    public delegate void Notification();
    class EventsManage
    {
        public event Notification TaskCompleted;
        public event EventHandler ProcessCompleted;

        public void TaskStart()
        {
            Console.WriteLine("Task Started");
            OnTaskCompleted();
            Console.WriteLine("Process Started");
            OnPorcessCompleted();
        }

        protected virtual void OnTaskCompleted()
        {
            TaskCompleted?.Invoke();
        }

        protected virtual void OnPorcessCompleted()
        {
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
        }

        //event handler
        public void completed()
        {
            Console.WriteLine("Task Completed!!!");
        }
        public void Pcompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completted...!!");
        }
    }
}
