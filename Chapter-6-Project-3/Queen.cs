using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Project_3
{
    class Queen
    {
        
        private Worker[] workers;
        public string GetWorkers()
        {
            string Message = "";
            Message += ($"The Queen has received {workers.Length} workers.\r\n\r\n");
            for (int worker = 0; worker < workers.Length; worker++)
            {
                Worker currentWorker = workers[worker];
                Message += ($"Worker #{worker + 1} can do {currentWorker.GetNumberJobsICanDo()} jobs.\r\n");
                Message += currentWorker.GetJobsICanDo();
                Message += "\r\n";

            }
            return Message;
        }

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public int AssignWork(string job, int shifts)
        {
            for (int worker = 0; worker < workers.Length; worker++)
                if (CheckWorker(worker, job))
                {
                    workers[worker].DoThisJob(job, shifts);
                    return worker;
                }
            return -1;
        }
 
        private bool CheckWorker(int worker, string job)
        {
            if (workers[worker].GetJobsICanDo().Contains(job) && 
                workers[worker].CurrentJob.Equals("")) return true;
            return false;
        }
    }
}
